namespace Q10.Pickpoint.Models.JsonModel;

public class Json2683
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
        public string Event { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string Location { get; set; }
        public string EventBegin { get; set; }
        public string EventEnd { get; set; }
        public string Website { get; set; }
        public int GlobalId { get; set; }
    }

}