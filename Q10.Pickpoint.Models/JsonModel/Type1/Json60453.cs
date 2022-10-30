namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json60453 : JsonType1
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
        public int Iden { get; set; }
        public string Nameen { get; set; }
        public string AdmAreaen { get; set; }
        public string Districten { get; set; }
        public string Locationen { get; set; }
        public string LocationClarificationen { get; set; }
        public int GlobalId { get; set; }
    }

}