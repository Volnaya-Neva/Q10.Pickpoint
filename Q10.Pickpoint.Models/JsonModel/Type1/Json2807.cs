namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json2807 : JsonType1
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
        public object Iden { get; set; }
        public object AdmAreaen { get; set; }
        public object Districten { get; set; }
        public string Addressen { get; set; }
        public string Locationen { get; set; }
        public string ExtraInfoen { get; set; }
        public string Nameen { get; set; }
        public string Positionen { get; set; }
        public int GlobalId { get; set; }
    }

}