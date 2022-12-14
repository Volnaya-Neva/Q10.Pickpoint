namespace Q10.Pickpoint.Models.JsonModel.TypeOther;

public class Json2252 : JsonType4
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
        public object[] Coordinates { get; set; }
        public string Type { get; set; }
    }

    public class Properties
    {
        public string RouteName { get; set; }
        public string Description { get; set; }
        public string MainObjects { get; set; }
        public string WebSite { get; set; }
        public string GlobalId { get; set; }
    }

}