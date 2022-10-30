namespace Q10.Pickpoint.Models.JsonModel;

public class Json2206
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
        public string Iden { get; set; }
        public string Nameen { get; set; }
        public object AdmAreaen { get; set; }
        public string Routeen { get; set; }
        public string Tracken { get; set; }
        public long GlobalId { get; set; }
    }

}