namespace Q10.Pickpoint.Models.JsonModel;

public class Json749
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
        public string WebSite { get; set; }
        public int GlobalId { get; set; }
        public int ContactPhoneisdeleted0 { get; set; }
        public string ContactPhoneContactPhone0 { get; set; }
        public int ContactPhoneGlobalId0 { get; set; }
        public int Faxisdeleted0 { get; set; }
        public string FaxFax0 { get; set; }
        public int FaxGlobalId0 { get; set; }
        public int ContactPhoneisdeleted1 { get; set; }
        public string ContactPhoneContactPhone1 { get; set; }
        public int ContactPhoneGlobalId1 { get; set; }
    }

}