namespace Q10.Pickpoint.Models.JsonModel;

public class Json62221
{
    public Feature[] Features { get; set; }
    public string Type { get; set; }

    public class Feature
    {
        public Geometry Geometry { get; set; }
        public Properties Properties { get; set; }
        public string Type { get; set; }
    }

    public class Geometry
    {
        public object[][][] Coordinates { get; set; }
        public string Type { get; set; }
    }

    public class Properties
    {
        public string WorkType { get; set; }
        public string Area { get; set; }
        public string Address { get; set; }
        public string RegistryContractNumber { get; set; }
        public string ContractStatus { get; set; }
        public string Customer { get; set; }
        public string Contractor { get; set; }
        public int WorkYear { get; set; }
        public string PlannedStartDate { get; set; }
        public string PlannedEndDate { get; set; }
        public string ActualStartDate { get; set; }
        public string ActualEndDate { get; set; }
        public string WorkStatus { get; set; }
        public long GlobalId { get; set; }
    }

}