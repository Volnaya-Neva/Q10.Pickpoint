namespace Q10.Pickpoint.Models.JsonModel;

public class Json62884
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
        public object AeroexpressEn { get; set; }
        public AeroexpressstationEn AeroexpressStationEn { get; set; }
        public object AeroexpressTerminalEn { get; set; }
        public object AeroexpressTicketWindowEn { get; set; }
        public object AeroexpressTicketAutomatEn { get; set; }
        public string AeroexpressWorkingHoursEn { get; set; }
        public string LatitudeWgs84En { get; set; }
        public string LongitudeWgs84En { get; set; }
        public int GlobalId { get; set; }
    }

    public class AeroexpressstationEn
    {
        public int GlobalId { get; set; }
        public string Value { get; set; }
    }

}