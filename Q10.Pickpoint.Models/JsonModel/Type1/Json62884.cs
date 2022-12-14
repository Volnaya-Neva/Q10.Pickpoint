namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json62884 : JsonType1
{
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
        public string GlobalId { get; set; }
    }

    public class AeroexpressstationEn
    {
        public string GlobalId { get; set; }
        public string Value { get; set; }
    }

}