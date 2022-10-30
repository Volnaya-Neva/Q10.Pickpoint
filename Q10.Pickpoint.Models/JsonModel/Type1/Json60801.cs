namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json60801 : JsonType1
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
        public string LocationDescription { get; set; }
        public string LocationClarification { get; set; }
        public string SkUrefill { get; set; }
        public string Provider { get; set; }
        public long GlobalId { get; set; }
    }

}