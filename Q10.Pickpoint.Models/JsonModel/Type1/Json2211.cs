namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json2211 : JsonType1
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
        public string BoothNumberen { get; set; }
        public string Locationen { get; set; }
        public string AdmAreaen { get; set; }
        public string Districten { get; set; }
        public string StreetNameen { get; set; }
        public string ActualLocatonen { get; set; }
        public string ClarificationOfWorkingHoursen { get; set; }
        public string UnoMen { get; set; }
        public string OnTerritoryOfMoscowen { get; set; }
        public string WorkingHoursen { get; set; }
        public string PointTypeen { get; set; }
        public string PaymentTypeen { get; set; }
        public long GlobalId { get; set; }
    }

}