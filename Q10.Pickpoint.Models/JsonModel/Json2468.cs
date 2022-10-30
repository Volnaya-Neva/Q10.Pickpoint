namespace Q10.Pickpoint.Models.JsonModel;

public class Json2468
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
        public string Location { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string WorkStartDate { get; set; }
        public string WorkEndDate { get; set; }
        public string WorkType { get; set; }
        public string WorkStatus { get; set; }
        public int GlobalId { get; set; }
    }

}