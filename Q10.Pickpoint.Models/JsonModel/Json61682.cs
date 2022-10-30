namespace Q10.Pickpoint.Models.JsonModel;

public class Json61682
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
        public object TypeObjecten { get; set; }
        public string NameOwneren { get; set; }
        public object OnTerritoryOfMoscowen { get; set; }
        public object AdmAreaen { get; set; }
        public object Districten { get; set; }
        public string Locationen { get; set; }
        public string LongitudeWgs84En { get; set; }
        public string LatitudeWgs84En { get; set; }
        public long GlobalId { get; set; }
    }

}