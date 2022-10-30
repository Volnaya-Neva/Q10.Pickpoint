namespace Q10.Pickpoint.Models.JsonModel;

public class Json2895
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
        public int Iden { get; set; }
        public string ObjectNameOnDocen { get; set; }
        public string ObjectNameen { get; set; }
        public long GlobalId { get; set; }
        public LinkEn Linken { get; set; }
    }

    public class LinkEn
    {
        public int GlobalId { get; set; }
        public string Value { get; set; }
    }

}