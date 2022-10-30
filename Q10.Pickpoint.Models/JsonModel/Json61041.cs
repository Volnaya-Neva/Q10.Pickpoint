namespace Q10.Pickpoint.Models.JsonModel;

public class Json61041
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
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string ObjectCitySignificance { get; set; }
        public string WorkScopeModifyReason { get; set; }
        public string ContractNumber { get; set; }
        public string ContractorName { get; set; }
        public string Customer { get; set; }
        public int WorkYear { get; set; }
        public string StartDatePlanned { get; set; }
        public string EndDatePlanned { get; set; }
        public string StartDateActual { get; set; }
        public string EndDateActual { get; set; }
        public string WorkEntityState { get; set; }
        public string WorkDeleteReason { get; set; }
        public string WorkStopReason { get; set; }
        public long GlobalId { get; set; }
    }

}