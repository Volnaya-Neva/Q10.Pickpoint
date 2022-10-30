namespace Q10.Pickpoint.Models.JsonModel;

public class Json62701
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
        public int Id { get; set; }
        public string NameOfStation { get; set; }
        public string Line { get; set; }
        public string LongitudeWgs84 { get; set; }
        public string LatitudeWgs84 { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public int Year { get; set; }
        public string Month { get; set; }
        public long GlobalId { get; set; }
    }

}