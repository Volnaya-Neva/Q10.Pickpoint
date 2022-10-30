namespace Q10.Pickpoint.Models.JsonModel;

public class Json61605
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
        public string FullNameen { get; set; }
        public string ShortNameen { get; set; }
        public string AdmAreaen { get; set; }
        public string Districten { get; set; }
        public string Addressen { get; set; }
        public int Indexen { get; set; }
        public string ChiefPositionen { get; set; }
        public string ChiefNameen { get; set; }
        public string WebSiteen { get; set; }
        public int GlobalId { get; set; }
        public int PublicPhoneenGlobalId0 { get; set; }
        public int PublicPhoneenisdeleted0 { get; set; }
        public string PublicPhoneenPublicPhoneen0 { get; set; }
        public int EmailenGlobalId0 { get; set; }
        public int Emailenisdeleted0 { get; set; }
        public string EmailenEmailen0 { get; set; }
    }

}