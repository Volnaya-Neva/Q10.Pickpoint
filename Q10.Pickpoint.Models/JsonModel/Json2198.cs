namespace Q10.Pickpoint.Models.JsonModel;

public class Json2198
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
        public int Iden { get; set; }
        public string Nameen { get; set; }
        public TunnelEn Tunnelen { get; set; }
        public object AdmAreaen { get; set; }
        public object Districten { get; set; }
        public string LongitudeWgs84En { get; set; }
        public string LatitudeWgs84En { get; set; }
        public long GlobalId { get; set; }
    }

    public class TunnelEn
    {
        public long GlobalId { get; set; }
        public string Value { get; set; }
    }

}