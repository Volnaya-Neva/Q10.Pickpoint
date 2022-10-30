namespace Q10.Pickpoint.Models.JsonModel;

public class Json61359
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
        public string Codeen { get; set; }
        public string Nameen { get; set; }
        public string AdmAreaen { get; set; }
        public string Districten { get; set; }
        public string Addressen { get; set; }
        public string UnoMen { get; set; }
        public string LongitudeWgs84En { get; set; }
        public string LatitudeWgs84En { get; set; }
        public float? FacilityAreaen { get; set; }
        public string ObjectTypeen { get; set; }
        public string Specializationen { get; set; }
        public string PeriodOfPlacementen { get; set; }
        public string ContractTypeen { get; set; }
        public string ContractStatusen { get; set; }
        public string ContractNumberen { get; set; }
        public string NameOfBusinessEntityen { get; set; }
        public string ContractBeginen { get; set; }
        public string ContractEnden { get; set; }
        public string ContractBasisen { get; set; }
        public object ObjectPhotoen { get; set; }
        public string StartDateTradingen { get; set; }
        public string EndDateTradingen { get; set; }
        public long GlobalId { get; set; }
    }

}