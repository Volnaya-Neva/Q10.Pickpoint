namespace Q10.Pickpoint.Models.JsonModel.Type3;

public class Json62904 : JsonType3
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
        public float[][][] Coordinates { get; set; }
        public string Type { get; set; }
    }

    public class Properties
    {
        public string RouteNumber { get; set; }
        public string RouteName { get; set; }
        public string TrackOfFollowing { get; set; }
        public string ReverseTrackOfFollowing { get; set; }
        public string TypeOfTransport { get; set; }
        public string CarrierName { get; set; }
        public string StopInterval { get; set; }
        public string WorkTime { get; set; }
        public long GlobalId { get; set; }
    }

}