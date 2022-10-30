namespace Q10.Pickpoint.Models.JsonModel;

public class Json654
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
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string ManagementCompany { get; set; }
        public string LegalAddressOfManagementCompany { get; set; }
        public string MarketType { get; set; }
        public string ExtraInfo { get; set; }
        public int GlobalId { get; set; }
    }

}