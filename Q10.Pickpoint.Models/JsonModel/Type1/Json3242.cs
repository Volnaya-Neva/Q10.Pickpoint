namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json3242 : JsonType1
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
        public string ThemeOfTheSeminar { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string Data { get; set; }
        public string Time { get; set; }
        public string Venue { get; set; }
        public string ContactName { get; set; }
        public string ExtraInfo { get; set; }
        public int GlobalId { get; set; }
        public int PublicPhoneisdeleted0 { get; set; }
        public int PublicPhoneGlobalId0 { get; set; }
        public string PublicPhonePublicPhone0 { get; set; }
    }

}