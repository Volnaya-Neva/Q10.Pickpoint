namespace Q10.Pickpoint.Models.JsonModel;

public class Json1106
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
        public string Address { get; set; }
        public float FieldArea { get; set; }
        public string CadastralNumber { get; set; }
        public float CadastralFieldCoast { get; set; }
        public string UsageType { get; set; }
        public int AmountObjectArea { get; set; }
        public string SubjectOfTrades { get; set; }
        public string TradesForm { get; set; }
        public float LicensePrimeCost { get; set; }
        public string StartPriceType { get; set; }
        public string TradesType { get; set; }
        public string Stage { get; set; }
        public string StartReceptionDate { get; set; }
        public string EndReceptionDate { get; set; }
        public string TradesDate { get; set; }
        public string ExtraInfo { get; set; }
        public int GlobalId { get; set; }
    }

}