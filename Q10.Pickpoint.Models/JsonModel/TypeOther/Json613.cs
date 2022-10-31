namespace Q10.Pickpoint.Models.JsonModel.TypeOther;

public class Json613 : JsonType4
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
        public object[][][] Coordinates { get; set; }
        public string Type { get; set; }
    }

    public class Properties
    {
        public string ObjectNameOnDoc { get; set; }
        public string GlobalId { get; set; }
    }

}