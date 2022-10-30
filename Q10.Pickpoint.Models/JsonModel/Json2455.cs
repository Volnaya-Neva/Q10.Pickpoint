namespace Q10.Pickpoint.Models.JsonModel;

public class Json2455
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
        public int Period { get; set; }
        public string Sector { get; set; }
        public string AdmArea { get; set; }
        public string Location { get; set; }
        public int GlobalId { get; set; }
    }

}