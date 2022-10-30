namespace Q10.Pickpoint.Models.JsonModel.Type3;

public class Json1682 : JsonType3
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
        public string Name { get; set; }
        public string PlaceId { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string CoordinateCenters { get; set; }
        public int GlobalId { get; set; }
    }

}