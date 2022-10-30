namespace Q10.Pickpoint.Models.JsonModel;

public class Json2703
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
        public string Event { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string Period { get; set; }
        public string WorkingHours { get; set; }
        public string Goods { get; set; }
        public string Link { get; set; }
        public int GlobalId { get; set; }
    }

}