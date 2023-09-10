using System;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;

namespace SmartTestAutomation.Steps.Core
{
    public class FeatureStepDefinitionsGenerator
    {
        private readonly IReadOnlyOptions _options;

        private readonly Dictionary<string, string> _classResults = new Dictionary<string, string>();

        public FeatureStepDefinitionsGenerator() => _options = new Options();

        public FeatureStepDefinitionsGenerator(IReadOnlyOptions options) => _options = options;

        public IReadOnlyDictionary<string, string> Create(string name,string workingDir)
        {
            CreateEntryAsClass(name, workingDir);
            return _classResults;
        }

        private readonly List<string> gharekin = new List<string> { "Given", "And", "Then", "When" };
        private readonly List<string> gharekinParent = new List<string> { "Given", "When", "Then" };
        private readonly List<string> gharekinChild = new List<string> { "And" };

        private string CreateEntryAsClass(string name,string workingDir)
        {
            var lines = File.ReadAllLines(workingDir +"\\"+ name+ ".feature");

           
            var className = (name + "StepDefinitions").SnakeToUpperCamel();
           
            string distPath = ReplaceFirstOccurrence(workingDir,"Features", "StepDefinitions") + "\\" + className +".cs";
            if (File.Exists(distPath))
            {
                var linesFile = File.ReadAllLines(distPath);
                var methods = GenerateMethods(lines.ToList());

                for (int i = 0; i < methods.Count; i++)
                {
                    foreach (var line in File.ReadAllLines(distPath))
                    {
                        if (line.Contains(Filter(methods[i])))
                        {
                            methods.RemoveAll(x => x == methods[i]);
                            break;
                        }
                    }
                }
                FileStream fs = new FileStream(distPath, FileMode.Open, FileAccess.ReadWrite);
                fs.Seek(0, SeekOrigin.End);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(methods.ToString());
                sw.Close();
                fs.Close();
            }
            else
            {
                var result = CreateImmutableClass(className, lines.ToList(), distPath);
                _classResults[className] = result;
                using (StreamWriter sw = File.CreateText(distPath))
                {
                    sw.Write(_classResults[className]);
                }
            }

            return name.SnakeToUpperCamel();
        }
        private string ReplaceFirstOccurrence(string Source, string Find, string Replace)
        {
            int Place = Source.IndexOf(Find);
            string result = Source.Remove(Place, Find.Length).Insert(Place, Replace);
            return result;
        }
        private string Filter(string s)
        {
            var chars = new[] { '*', '/', '#' };
            var filteredChars = s.ToArray();
            return new string(filteredChars
                     .Where(ch => !chars.Contains(ch))
                     .Select(ch => ch == ' ' ? '-' : ch).ToArray());
        }

        public void EditorialResponse(string path, string word, string replacement)
        {
            StreamReader reader = new StreamReader(path);
            string input = reader.ReadToEnd();

            using (StreamWriter writer = new StreamWriter(path, true))
            {
                {
                    string output = input.Replace(word, replacement);
                    writer.Write(output);
                }
                writer.Close();
            }
        }

        [SecuritySafeCritical]
        public static StreamWriter CreateText(string path)
        {
            if (path == null)
            {
                throw new ArgumentNullException("path");
            }
            return new StreamWriter(path, false);  
        }

        public static string RemoveSpecialCharacters(string str)
        {
            return Regex.Replace(str, "[^a-zA-Z0-9_.]+", "", RegexOptions.Compiled);
        }

        private string GetFirstWord(string text)
        {
            var scenarios = text.Trim();
            if (!scenarios.Any(Char.IsWhiteSpace))
                return text;

            return scenarios.Split(' ').FirstOrDefault();
        }
        private string RemoveFirstWord(string text)
        {
            int i = text.IndexOf(" ") + 1;
            return  text.Substring(i);
        }
        private static readonly Regex sWhitespace = new Regex(@"\s+");
        public static string ReplaceWhitespace(string input, string replacement)
        {
            return sWhitespace.Replace(input, replacement);
        }
        private string RemoveWhitespace(string input)
        {
            return new string(input.ToCharArray()
                .Where(c => !Char.IsWhiteSpace(c))
                .ToArray());
        }
        private string GetStepMethodAttrubute(string text)
        {
            //var t = betweenStrings(@text, "&quot", "&quot");
            var attribute = new StringBuilder();
            attribute.Append("[");
            attribute.Append(GetFirstWord(text));
            attribute.Append("(@");
            attribute.Append(@"""");
            attribute.Append(@RemoveFirstWord(text));
            attribute.Append(@"""");
            attribute.Append(@")]");
            return attribute.ToString();
        }
        private string GetStepMethod(string text)
        {
            var method = new StringBuilder();
            method.Append("public void ");
            method.Append(RemoveWhitespace(text));
            method.Append(" ");
            method.Append("()");
            method.AppendLine("{");
            method.AppendLine("throw new PendingStepException();");
            method.AppendLine("}");
            return method.ToString();
        }

        //public static String betweenStrings(String text, String start, String end)
        //{
        //    int p1 = text.IndexOf(start) + start.Length;
        //    int p2 = text.IndexOf(end, p1);

        //    if (end == "") return (text.Substring(p1));
        //    else return text.Substring(p1, p2 - p1);
        //}
        private string CreateImmutableClass(string name, List<string> scenarios,string distPath)
        {
            var builder = new ClassBuilder();
            try
            {
                var nameCamelUpper = name.SnakeToUpperCamel();

                builder += "using System;";
                builder += "using TechTalk.SpecFlow;";

                {
                    var listTypeEnumNames = Enum.GetNames(typeof(ListType));
                }

                builder.AddLine();

                if (string.IsNullOrWhiteSpace(_options.NameSpace) == false)
                {
                    builder += $"namespace {_options.NameSpace}";
                    builder += "{";
                    builder.Indent();
                }
                builder += $"[Binding]";
                builder += $"public class {nameCamelUpper}";
                builder += "{";
                builder.Indent();
                var methodList = new List<string>();
                scenarios.RemoveAll(s => string.IsNullOrWhiteSpace(s));
                bool parent = false;
                var gharekinParentName = "";
                foreach (var s in scenarios.Distinct().ToList())
                {
                    var gharekinChildName = "";
                    
                    var scenario = s.Replace("\n", "").Replace("\t", "").Trim();
                    bool child = false;

                    if (scenario.Split(' ').Any(x => gharekin.Contains(x)))
                    {
                        if (scenario.Split(' ').Any(x => gharekinParent.Contains(x)))
                        {
                            parent = true;
                            gharekinParentName = scenario.Split(' ')[0].ToString();
                        }
                        if (scenario.Split(' ').Any(x => gharekinChild.Contains(x)))
                        {
                            child = true;
                            gharekinChildName = scenario.Split(' ')[0].ToString();
                        }
                        if (parent & child)
                        {
                            if (!string.IsNullOrEmpty(gharekinChildName) && !string.IsNullOrEmpty(gharekinParentName))
                            {
                                var replaceScenario = scenario.Replace(gharekinChildName, gharekinParentName);
                                scenario = replaceScenario;
                                child = false;
                            }
                        }
                        var method = GetStepMethod(scenario);
                        //methodList.Add(method);
                        //methodList.Distinct().ToList();
                        //bool existMethod = false;
                        //if (methodList.Count > 0 )
                        //{
                        //     existMethod = methodList.Any(s=>builder.ToString().Contains(s));
                        //}
                        //if (existMethod)
                        //{
                           
                        //}
                        builder.Indent();
                        builder += GetStepMethodAttrubute(scenario);
                        builder += method;
                        builder.Dedent();
                        //existMethod = false;
                    }
                }


                builder.Dedent();
                builder += $"}}";

                if (string.IsNullOrWhiteSpace(_options.NameSpace) == false)
                {
                    builder.Dedent();
                    builder += $"}}";
                }
            }
            catch(Exception e)
            {
                throw ;
            }
            return builder.ToString();
        }

        private List<string> GenerateMethods(List<string> scenarios)
        {
            List<string> scenariosMethod = new List<string>();
            scenarios.RemoveAll(s => string.IsNullOrWhiteSpace(s));
            bool parent = false;
            var gharekinParentName = "";
            var method = new StringBuilder();
            foreach (var s in scenarios)
            {
                var gharekinChildName = "";
                var scenario = s.Replace("\n", "").Replace("\t", "");
                bool child = false;

                if (scenario.Split(' ').Any(x => gharekin.Contains(x)))
                {
                    if (scenario.Split(' ').Any(x => gharekinParent.Contains(x)))
                    {
                        parent = true;
                        gharekinParentName = scenario.Split(' ')[0].ToString();
                    }
                    if (scenario.Split(' ').Any(x => gharekinChild.Contains(x)))
                    {
                        child = true;
                        gharekinChildName = scenario.Split(' ')[0].ToString();
                    }
                    if (scenario!= null && parent && child)
                    {
                        var replaceScenario = scenario.Replace(gharekinChildName, gharekinParentName);
                        scenario = replaceScenario;
                        child = false;
                    }
                    method = new StringBuilder();
                   // method.Append("public void ");
                    method.Append(RemoveWhitespace(scenario));
                  //  method.Append(" ");
                   // method.Append("()");
                   // method.AppendLine("{");
                    //method.AppendLine("throw new PendingStepException();");
                   // method.AppendLine("}");
                }
                scenariosMethod.Add(method.ToString());
                scenariosMethod.RemoveAll(s => string.IsNullOrWhiteSpace(s));
            }
            return scenariosMethod;
        }

     


      

      


      

        //static Exception CreateException(ICharReader fileReader, string message)
        //    => new Exception($"[Error] {fileReader.CurrentLine}:{fileReader.CurrentLineOffset} {message}");
    }

    //internal static class FileError
    //{
    //    internal static Exception UnexpectedToken(ICharReader fileReader, string expected, string actual)
    //        => new Exception($"[Error] {fileReader.CurrentLine}:{fileReader.CurrentLineOffset}" +
    //                         $"expected: {expected}, found: {actual}");
    //}
}