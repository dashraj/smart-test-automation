using SmartTestAutomation.Steps.Core;

namespace SmartTestAutomation.Core.Helpers
{
    public class FileHelpers
    {
        public static IEnumerable<FeatureModel> ReadTestCases(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);

            var features = new List<FeatureModel>();
            foreach (string line in lines.Skip(1))
            {
                string[] parts = line.Split('|');
                FeatureModel? model;

                if (!String.IsNullOrEmpty(parts[0]))
                {
                    model = new FeatureModel
                    {
                        Feature = parts[0],
                        Description = parts[1]
                    };
                }
                else
                {
                    model = features.LastOrDefault();
                }

                Scenario scenario = new()
                {
                    ScenarioType = line.Contains('<') ? "Scenario Outline" : "Scenario",
                    ScenarioName = parts[2],
                    Given = parts[3].Split(',').ToList(),
                    When = parts[4].Split(',').ToList(),
                    Then = parts[5],
                };
                model!.Scenarios ??= new List<Scenario>();
                model.Scenarios.Add(scenario);

                features.Add(model);

            }
            return features;
        }

        public static void CreateFeatures(IEnumerable<FeatureModel> lines, string destinationFolder)
        {
            foreach (var line in lines)
            {
                using StreamWriter writer = new(@$"{destinationFolder}\{line.Feature}.feature");
                writer.WriteLine($"Feature: {line.Feature}");
                writer.WriteLine($"  {line.Description}");
                writer.WriteLine();

                foreach (var scenario in line.Scenarios!)
                {
                    writer.WriteLine($"{scenario.ScenarioType}: {scenario.ScenarioName}");

                    writer.WriteLine($"  Given {scenario?.Given![0]}");

                    foreach (var given in scenario?.Given!.Skip(1)!)
                    {
                        writer.WriteLine($"  And {given.Trim()}");
                    }

                    writer.WriteLine($"  When {scenario.When![0]}");

                    foreach (var when in scenario.When!.Skip(1)!)
                    {
                        writer.WriteLine($"  And {when.Trim()}");
                    }

                    writer.WriteLine($"  Then {scenario.Then}");

                    writer.WriteLine();
                }
            }
        }

        public static void CreateStepDefinitions(IEnumerable<FeatureModel> lines,string workingDir, string projectName)
        {
           
            foreach (var line in lines.Select(x => x.Feature).Distinct())
            {
                var options = new Options
                {
                    DeclareDataMember = false,
                    NameSpace = projectName + ".StepDefinitions"
                };

                var classData = new FeatureStepDefinitionsGenerator(options).Create(line + "", workingDir);
            }
        }
    }
}