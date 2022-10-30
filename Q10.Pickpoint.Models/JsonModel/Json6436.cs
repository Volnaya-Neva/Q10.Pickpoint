namespace Q10.Pickpoint.Models.JsonModel;

public class Json6436
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
        public string Nameen { get; set; }
        public object AdmAreaen { get; set; }
        public object Districten { get; set; }
        public string Addressen { get; set; }
        public string UnoMen { get; set; }
        public float? FacilityAreaen { get; set; }
        public object ObjectTypeen { get; set; }
        public object Specializationen { get; set; }
        public object PeriodOfPlacementen { get; set; }
        public object ContractTypeen { get; set; }
        public object ContractStatusen { get; set; }
        public string ContractNumberen { get; set; }
        public string NameOfBusinessEntityen { get; set; }
        public string ContractBeginen { get; set; }
        public string ContractEnden { get; set; }
        public object ContractBasisen { get; set; }
        public string ObjectPhotoen { get; set; }
        public string StartDateTradingen { get; set; }
        public string EndDateTradingen { get; set; }
        public long GlobalId { get; set; }
    }

}