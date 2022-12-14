namespace Q10.Pickpoint.Models.JsonModel;

public abstract class JsonType1 : IJsonType
{
    public int Number { get; set; }
    
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
        public string CommonName { get; set; }
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public string Area { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string GlobalId { get; set; }
    }
}