namespace Q10.Pickpoint.Models.JsonModel;

public class Json3295
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
        public float[] Coordinates { get; set; }
        public string Type { get; set; }
    }

    public class Properties
    {
        public string WorkType { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public int EntranceNumber { get; set; }
        public string KindOfWork { get; set; }
        public int WorkScope { get; set; }
        public string Unit { get; set; }
        public string ContractNumber { get; set; }
        public string ContractorName { get; set; }
        public string Customer { get; set; }
        public int WorkYear { get; set; }
        public string StartDatePlanned { get; set; }
        public string EndDatePlanned { get; set; }
        public string StartDateActual { get; set; }
        public string EndDateActual { get; set; }
        public string WorkEntityState { get; set; }
        public long GlobalId { get; set; }
    }

}