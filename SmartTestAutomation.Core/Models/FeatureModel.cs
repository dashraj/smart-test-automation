namespace SmartTestAutomation.Core
{
    public class FeatureModel
    {
        private string? feature;
        private string? description;
        private List<Scenario>? scenarios;

        public string? Feature { get => feature; set => feature = value; }

        public string? Description { get => description; set => description = value; }

        public List<Scenario>? Scenarios { get => scenarios; set => scenarios = value; }
    }
}
