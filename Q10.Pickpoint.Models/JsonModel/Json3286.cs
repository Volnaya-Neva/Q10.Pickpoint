namespace Q10.Pickpoint.Models.JsonModel;

public class Json3286
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
        public string Kind { get; set; }
        public string Photo { get; set; }
        public string Info { get; set; }
        public string CageLocation { get; set; }
        public long GlobalId { get; set; }
    }

}