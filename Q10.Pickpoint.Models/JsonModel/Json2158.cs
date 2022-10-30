namespace Q10.Pickpoint.Models.JsonModel;

public class Json2158
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
        public int RegisterIdEn { get; set; }
        public string AddressEn { get; set; }
        public string ObjectNameEn { get; set; }
        public object AdmAreaEn { get; set; }
        public object DistrictEn { get; set; }
        public string EmailEn { get; set; }
        public string WebSiteEn { get; set; }
        public string HelpPhoneEn { get; set; }
        public string HelpPhoneExtensionEn { get; set; }
        public long GlobalId { get; set; }
    }

}