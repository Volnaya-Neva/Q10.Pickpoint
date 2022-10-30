namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json2404 : JsonType1
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
        public string LegalAddress { get; set; }
        public string Address { get; set; }
        public string ChiefName { get; set; }
        public string ChiefPosition { get; set; }
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public string Ogrn { get; set; }
        public string PublicPhone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string ExtraInfo { get; set; }
        public int GlobalId { get; set; }
    }

}