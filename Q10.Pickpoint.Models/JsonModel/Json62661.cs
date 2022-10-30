namespace Q10.Pickpoint.Models.JsonModel;

public class Json62661
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
        public string LocationEn { get; set; }
        public string TaxiEn { get; set; }
        public float LengthKmEn { get; set; }
        public string DateOfEntryEn { get; set; }
        public long GlobalId { get; set; }
    }

}