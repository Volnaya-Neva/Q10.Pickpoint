namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json2976 : JsonType1
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
        public string DistributorNetworken { get; set; }
        public string LegalEntityen { get; set; }
        public object Categoryen { get; set; }
        public object AdmAreaen { get; set; }
        public object Districten { get; set; }
        public string Addressen { get; set; }
        public object CardTypesen { get; set; }
        public string Phoneen { get; set; }
        public float MinDiscounten { get; set; }
        public float MaxDiscounten { get; set; }
        public string TermsDiscounten { get; set; }
        public long GlobalId { get; set; }
    }

}