namespace Q10.Pickpoint.Models.JsonModel;

public class Json61604
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
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public int Index { get; set; }
        public string ChiefPosition { get; set; }
        public string ChiefName { get; set; }
        public string WebSite { get; set; }
        public int GlobalId { get; set; }
        public int PublicPhoneGlobalId0 { get; set; }
        public int PublicPhoneisdeleted0 { get; set; }
        public string PublicPhonePublicPhone0 { get; set; }
        public int EmailGlobalId0 { get; set; }
        public int Emailisdeleted0 { get; set; }
        public string EmailEmail0 { get; set; }
    }

}