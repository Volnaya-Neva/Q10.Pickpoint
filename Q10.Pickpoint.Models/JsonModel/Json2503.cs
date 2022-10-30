namespace Q10.Pickpoint.Models.JsonModel;

public class Json2503
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
        public int Iden { get; set; }
        public string FullNameen { get; set; }
        public string ShortNameen { get; set; }
        public object AdmAreaen { get; set; }
        public object Districten { get; set; }
        public int Indexen { get; set; }
        public string Addressen { get; set; }
        public string Phoneen { get; set; }
        public string ClarificationOfVisitingHoursen { get; set; }
        public string ChiefNameen { get; set; }
        public string ClarificationOfDocumentsIssuanceHoursen { get; set; }
        public string ExtraInfoen { get; set; }
        public string ConditionalNumberen { get; set; }
        public int GlobalId { get; set; }
    }

}