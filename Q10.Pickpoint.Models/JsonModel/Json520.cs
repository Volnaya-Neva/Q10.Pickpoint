namespace Q10.Pickpoint.Models.JsonModel;

public class Json520
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
        public string FlatsAmount { get; set; }
        public string GlobalId { get; set; }
        public string Xwgs { get; set; }
        public string Ywgs { get; set; }
    }

}