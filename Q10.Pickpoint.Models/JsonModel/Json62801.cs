namespace Q10.Pickpoint.Models.JsonModel;

public class Json62801
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
        public string WorkPlaceDescription { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string WorkType { get; set; }
        public string Contractor { get; set; }
        public string WorkDateTime { get; set; }
        public long GlobalId { get; set; }
    }

}