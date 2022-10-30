namespace Q10.Pickpoint.Models.JsonModel;

public class Json62945
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
        public string NameEn { get; set; }
        public object ZoneTypeEn { get; set; }
        public object AdmAreaEn { get; set; }
        public object DistrictEn { get; set; }
        public string AddressEn { get; set; }
        public long GlobalId { get; set; }
    }

}