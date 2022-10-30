namespace Q10.Pickpoint.Models.JsonModel;

public class Json2033
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
        public string AddressEn { get; set; }
        public object MetroStationEn { get; set; }
        public object MetroLineEn { get; set; }
        public object WiFiAvailabilityEn { get; set; }
        public object BabyCareRoomEn { get; set; }
        public string SanitationFacilitiesEn { get; set; }
        public string WebSiteEn { get; set; }
        public string BusDestinationEn { get; set; }
        public string LocationCommentEn { get; set; }
        public string LatitudeWgs84En { get; set; }
        public string LongitudeWgs84En { get; set; }
        public int GlobalId { get; set; }
    }

}