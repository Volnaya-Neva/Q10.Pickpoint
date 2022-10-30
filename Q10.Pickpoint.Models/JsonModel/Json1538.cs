namespace Q10.Pickpoint.Models.JsonModel;

public class Json1538
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
        public string Unom { get; set; }
        public string LatitudeWgs84 { get; set; }
        public string LongitudeWgs84 { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Erkt { get; set; }
        public string Porch { get; set; }
        public string GlobalId { get; set; }
    }

}