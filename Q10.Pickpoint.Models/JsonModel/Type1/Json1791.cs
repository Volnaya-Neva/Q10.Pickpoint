namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json1791 : JsonType1
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
        public int GlobalId { get; set; }
        public string Name { get; set; }
        public string IsNetObject { get; set; }
        public object OperatingCompany { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public int SeatsCount { get; set; }
        public string SocialPrivileges { get; set; }
        public string LongitudeWgs84 { get; set; }
        public string LatitudeWgs84 { get; set; }
        public string PublicPhonePublicPhone0 { get; set; }
    }

}