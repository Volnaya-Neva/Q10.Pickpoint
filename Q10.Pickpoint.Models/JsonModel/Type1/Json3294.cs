namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json3294 : JsonType1
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
        public string Name { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string DocNumber { get; set; }
        public string DocDate { get; set; }
        public Link Link { get; set; }
        public long GlobalId { get; set; }
    }

    public class Link
    {
        public long GlobalId { get; set; }
        public string Value { get; set; }
    }

}