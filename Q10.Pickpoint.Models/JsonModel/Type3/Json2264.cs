namespace Q10.Pickpoint.Models.JsonModel.Type3;

public class Json2264 : JsonType3
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
        public string RouteName { get; set; }
        public string Location { get; set; }
        public string MainObjects { get; set; }
        public string ExtraInfo { get; set; }
        public string WebSite { get; set; }
        public int GlobalId { get; set; }
    }

}