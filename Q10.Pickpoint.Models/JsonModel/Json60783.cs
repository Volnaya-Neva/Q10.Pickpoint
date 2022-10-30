namespace Q10.Pickpoint.Models.JsonModel;

public class Json60783
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
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string Linear { get; set; }
        public string ConstructionSize { get; set; }
        public int? PartsAmount { get; set; }
        public long GlobalId { get; set; }
    }

}