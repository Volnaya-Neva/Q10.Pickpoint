namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json2445 : JsonType1
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
        public string FreshwaterBodyType { get; set; }
        public string FreshwaterBodyName { get; set; }
        public string SamplingSiteName { get; set; }
        public int GlobalId { get; set; }
    }

}