namespace Q10.Pickpoint.Models.JsonModel;

public class Json2118
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
        public string TpuNameEn { get; set; }
        public object AdmAreaEn { get; set; }
        public object DistrictEn { get; set; }
        public string NearStationEn { get; set; }
        public string YearOfComissioningEn { get; set; }
        public object StatusEn { get; set; }
        public string AvailableTransferEn { get; set; }
        public int? CarCapacityEn { get; set; }
        public int GlobalId { get; set; }
    }

}