namespace SmartTestAutomation.Core
{
    public class Scenario
    {
        private string? scenario;
        private List<string>? given;
        private List<string>? when;
        private string? then;

        public string? ScenarioName { get => scenario; set => scenario = value; }
        public List<string>? Given { get => given; set => given = value; }
        public List<string>? When { get => when; set => when = value; }
        public string? Then { get => then; set => then = value; }
        public string ScenarioType { get; internal set; }
    }
}
