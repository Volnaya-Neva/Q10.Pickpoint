namespace Q10.Pickpoint.Models.JsonModel;

public class Json2756
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
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string Location { get; set; }
        public int NumberOfAccessPoints { get; set; }
        public string WiFiName { get; set; }
        public int CoverageArea { get; set; }
        public string FunctionFlag { get; set; }
        public string AccessFlag { get; set; }
        public string Password { get; set; }
        public int GlobalId { get; set; }
    }

}