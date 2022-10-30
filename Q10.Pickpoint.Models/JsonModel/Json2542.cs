namespace Q10.Pickpoint.Models.JsonModel;

public class Json2542
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
        public string YardName { get; set; }
        public string YardType { get; set; }
        public float? YardArea { get; set; }
        public int GlobalId { get; set; }
    }

}