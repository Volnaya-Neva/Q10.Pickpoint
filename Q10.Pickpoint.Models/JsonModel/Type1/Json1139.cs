namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json1139 : JsonType1
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
        public int IdEn { get; set; }
        public string NameEn { get; set; }
        public object AdmAreaEn { get; set; }
        public object DistrictEn { get; set; }
        public string ParkNameEn { get; set; }
        public string WiFiNameEn { get; set; }
        public int CoverageAreaEn { get; set; }
        public object FunctionFlagEn { get; set; }
        public object AccessFlagEn { get; set; }
        public string PasswordEn { get; set; }
        public string LongitudeWgs84En { get; set; }
        public string LatitudeWgs84En { get; set; }
        public long GlobalId { get; set; }
    }

}