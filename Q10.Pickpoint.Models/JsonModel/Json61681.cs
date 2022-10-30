namespace Q10.Pickpoint.Models.JsonModel;

public class Json61681
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
        public string TypeObject { get; set; }
        public string NameOwner { get; set; }
        public string OnTerritoryOfMoscow { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string Location { get; set; }
        public string LongitudeWgs84 { get; set; }
        public string LatitudeWgs84 { get; set; }
        public long GlobalId { get; set; }
    }

}