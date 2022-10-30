namespace Q10.Pickpoint.Models.JsonModel;

public class Json2564
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
        public string Date { get; set; }
        public string MeetingPlace { get; set; }
        public string StartTime { get; set; }
        public string RouteDescription { get; set; }
        public string RouteLength { get; set; }
        public string Phone { get; set; }
        public string AdditionalProgram { get; set; }
        public long GlobalId { get; set; }
    }

}