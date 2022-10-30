namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json2186 : JsonType1
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
        public string AdmAreaen { get; set; }
        public string Districten { get; set; }
        public string Addressen { get; set; }
        public string WorkingHoursen { get; set; }
        public string WebSiteen { get; set; }
        public string Perioden { get; set; }
        public int GlobalId { get; set; }
    }

}