namespace Q10.Pickpoint.Models.JsonModel.Type3;

public class Json62662 : JsonType3
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
        public string Location { get; set; }
        public string Taxi { get; set; }
        public float LengthKm { get; set; }
        public string DateOfEntry { get; set; }
        public long GlobalId { get; set; }
    }

}