namespace Q10.Pickpoint.Models.JsonModel;

public class Json2133
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
        public object IdEn { get; set; }
        public string NameEn { get; set; }
        public string ShortNameEn { get; set; }
        public object AdmAreaEn { get; set; }
        public object DistrictEn { get; set; }
        public string AddressEn { get; set; }
        public string ResponsibilityAreaEn { get; set; }
        public string WorkingHoursEn { get; set; }
        public long GlobalId { get; set; }
    }

}