namespace Q10.Pickpoint.Models.JsonModel;

public class Json1344
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
        public Tunnel Tunnel { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string LongitudeWgs84 { get; set; }
        public string LatitudeWgs84 { get; set; }
        public long GlobalId { get; set; }
    }

    public class Tunnel
    {
        public long GlobalId { get; set; }
        public string Value { get; set; }
    }

}