namespace Q10.Pickpoint.Models.JsonModel;

public class Json3470
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
        public string Addressen { get; set; }
        public float FieldAreaen { get; set; }
        public string CadastralNumberen { get; set; }
        public float CadastralFieldCoasten { get; set; }
        public string UsageTypeen { get; set; }
        public int AmountObjectAreaen { get; set; }
        public object SubjectOfTradesen { get; set; }
        public object TradesFormen { get; set; }
        public float LicensePrimeCosten { get; set; }
        public object StartPriceTypeen { get; set; }
        public object TradesTypeen { get; set; }
        public object Stageen { get; set; }
        public string StartReceptionDateen { get; set; }
        public string EndReceptionDateen { get; set; }
        public string TradesDateen { get; set; }
        public string ExtraInfoen { get; set; }
        public int GlobalId { get; set; }
    }

}