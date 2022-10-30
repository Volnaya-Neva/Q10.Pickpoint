namespace Q10.Pickpoint.Models.JsonModel;

public class Json60784
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
        public string NameOrg { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string PostalCode { get; set; }
        public string Address { get; set; }
        public int GlobalId { get; set; }
        public int EmailGlobalId0 { get; set; }
        public int Emailisdeleted0 { get; set; }
        public string EmailEmail0 { get; set; }
        public int EmailGlobalId1 { get; set; }
        public int Emailisdeleted1 { get; set; }
        public string EmailEmail1 { get; set; }
        public int PhoneGlobalId0 { get; set; }
        public int Phoneisdeleted0 { get; set; }
        public string PhonePhone0 { get; set; }
        public int PhoneGlobalId1 { get; set; }
        public int Phoneisdeleted1 { get; set; }
        public string PhonePhone1 { get; set; }
        public int WebSiteGlobalId0 { get; set; }
        public int WebSiteisdeleted0 { get; set; }
        public string WebSiteWebSite0 { get; set; }
        public int WebSiteGlobalId1 { get; set; }
        public int WebSiteisdeleted1 { get; set; }
        public string WebSiteWebSite1 { get; set; }
    }

}