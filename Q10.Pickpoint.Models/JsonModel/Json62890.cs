namespace Q10.Pickpoint.Models.JsonModel;

public class Json62890
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
        public string Name { get; set; }
        public string Station { get; set; }
        public string RailwayLine { get; set; }
        public string WorkingHours { get; set; }
        public string LatitudeWgs84 { get; set; }
        public string LongitudeWgs84 { get; set; }
        public string ObjectStatus { get; set; }
        public long GlobalId { get; set; }
    }

}