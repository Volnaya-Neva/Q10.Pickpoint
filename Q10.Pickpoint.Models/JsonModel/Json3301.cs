namespace Q10.Pickpoint.Models.JsonModel;

public class Json3301
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
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public string Ogrn { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string LegalAddress { get; set; }
        public string Address { get; set; }
        public string ChiefName { get; set; }
        public string ExtraInfo { get; set; }
        public int GlobalId { get; set; }
    }

}