namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json2177 : JsonType1
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
        public string Nameen { get; set; }
        public string AdmAreaen { get; set; }
        public string Districten { get; set; }
        public string Addressen { get; set; }
        public string ExtraInfoen { get; set; }
        public int GlobalId { get; set; }
        public int PublicPhoneenisdeleted0 { get; set; }
        public string PublicPhoneenPublicPhoneen0 { get; set; }
        public int PublicPhoneenGlobalId0 { get; set; }
    }

}