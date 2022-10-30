namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json1499 : JsonType1
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
        public string Location { get; set; }
        public string Type { get; set; }
        public object PhotoClockType { get; set; }
        public float Power { get; set; }
        public string AdmArea { get; set; }
        public int GlobalId { get; set; }
    }

}