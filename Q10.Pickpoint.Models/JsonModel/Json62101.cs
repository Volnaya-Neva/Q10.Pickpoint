namespace Q10.Pickpoint.Models.JsonModel;

public class Json62101
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
        public float[][][] Coordinates { get; set; }
        public string Type { get; set; }
    }

    public class Properties
    {
        public string WorksPlace { get; set; }
        public int WorkYear { get; set; }
        public string OnTerritoryOfMoscow { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string WorksBeginDate { get; set; }
        public string PlannedEndDate { get; set; }
        public string ActualBeginDate { get; set; }
        public string ActualEndDate { get; set; }
        public string WorksType { get; set; }
        public string WorksStatus { get; set; }
        public string WorkReason { get; set; }
        public string Customer { get; set; }
        public string Contractor { get; set; }
        public long GlobalId { get; set; }
    }

}