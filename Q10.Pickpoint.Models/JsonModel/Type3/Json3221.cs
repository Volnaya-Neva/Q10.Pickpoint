namespace Q10.Pickpoint.Models.JsonModel.Type3;

public class Json3221 : JsonType3
{
    public class Properties
    {
        public string RouteNumber { get; set; }
        public string RouteName { get; set; }
        public string TrackOfFollowing { get; set; }
        public string ReverseTrackOfFollowing { get; set; }
        public string TypeOfTransport { get; set; }
        public string CarrierName { get; set; }
        public string GlobalId { get; set; }
    }
}