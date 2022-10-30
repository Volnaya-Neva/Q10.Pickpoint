namespace Q10.Pickpoint.Models.JsonModel;

public class Json3141
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
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string WorksBeginDate { get; set; }
        public string WorksEndDate { get; set; }
        public string WorksType { get; set; }
        public string WorksStatus { get; set; }
        public int GlobalId { get; set; }
    }

}