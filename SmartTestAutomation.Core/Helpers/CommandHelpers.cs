using System.Diagnostics;

namespace SmartTestAutomation.Core.Helpers
{
    public class CommandHelpers
    {
        public static string RunCommand(string command, string workingDirectory)
        {
            try
            {
                var process = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        Arguments = $"/c {command}",
                        RedirectStandardOutput = true,
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        WorkingDirectory = workingDirectory
                    }
                };

                process.Start();

                // Read the output
                string output = process.StandardOutput.ReadToEnd();

                // Wait for the process to exit
                process.WaitForExit();

                return output;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }

        }

        public static string ReplaceFirstOccurrence(string Source, string Find, string Replace)
        {
            int Place = Source.IndexOf(Find);
            string result = Source.Remove(Place, Find.Length).Insert(Place, Replace);
            return result;
        }
    }
}
