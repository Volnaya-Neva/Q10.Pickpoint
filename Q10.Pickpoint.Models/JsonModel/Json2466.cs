namespace Q10.Pickpoint.Models.JsonModel;

public class Json2466
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
        public string Country { get; set; }
        public string ContactName { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string LegalAddress { get; set; }
        public int GlobalId { get; set; }
        public int PublicPhoneisdeleted0 { get; set; }
        public string PublicPhonePublicPhone0 { get; set; }
        public int PublicPhoneGlobalId0 { get; set; }
        public int Faxisdeleted0 { get; set; }
        public string FaxFax0 { get; set; }
        public int FaxGlobalId0 { get; set; }
        public int Emailisdeleted0 { get; set; }
        public string EmailEmail0 { get; set; }
        public int EmailGlobalId0 { get; set; }
        public int Emailisdeleted1 { get; set; }
        public string EmailEmail1 { get; set; }
        public int EmailGlobalId1 { get; set; }
        public int WebSiteisdeleted0 { get; set; }
        public string WebSiteWebSite0 { get; set; }
        public int WebSiteGlobalId0 { get; set; }
        public int PublicPhoneisdeleted1 { get; set; }
        public string PublicPhonePublicPhone1 { get; set; }
        public int PublicPhoneGlobalId1 { get; set; }
        public int WebSiteisdeleted1 { get; set; }
        public string WebSiteWebSite1 { get; set; }
        public int WebSiteGlobalId1 { get; set; }
        public int PublicPhoneisdeleted2 { get; set; }
        public string PublicPhonePublicPhone2 { get; set; }
        public int PublicPhoneGlobalId2 { get; set; }
        public int PublicPhoneisdeleted3 { get; set; }
        public string PublicPhonePublicPhone3 { get; set; }
        public int PublicPhoneGlobalId3 { get; set; }
        public int Emailisdeleted2 { get; set; }
        public string EmailEmail2 { get; set; }
        public int EmailGlobalId2 { get; set; }
        public int WebSiteisdeleted2 { get; set; }
        public string WebSiteWebSite2 { get; set; }
        public int WebSiteGlobalId2 { get; set; }
    }

}