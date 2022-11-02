namespace Q10.Pickpoint.Models.JsonModel;

public abstract class JsonType3 : IJsonType
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
        public float[][][] Coordinates { get; set; }
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
        public float FieldArea { get; set; }
        public string CadastralNumber { get; set; }
        public float CadastralFieldCoast { get; set; }
        public string UsageType { get; set; }
        public int AmountObjectArea { get; set; }
        public string SubjectOfTrades { get; set; }
        public string TradesForm { get; set; }
        public string TradesType { get; set; }
        public string Stage { get; set; }
    }
}