namespace Q10.Pickpoint.Models.JsonModel;

public class Json2120
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
        public string LocationEn { get; set; }
        public string LocationClarificationEn { get; set; }
        public object CloseFlagEn { get; set; }
        public string CloseReasonEn { get; set; }
        public string ClarificationOfWorkingHoursEn { get; set; }
        public string BalanceholderEn { get; set; }
        public object HasPaymentTerminalEn { get; set; }
        public object PaidServiceEn { get; set; }
        public object DisabilityFriendlyEn { get; set; }
        public string UnomEn { get; set; }
        public object EntryStateEn { get; set; }
        public long GlobalId { get; set; }
    }

}