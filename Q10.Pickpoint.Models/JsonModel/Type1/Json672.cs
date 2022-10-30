namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json672 : JsonType1
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
        public string Address { get; set; }
        public string X { get; set; }
        public string Y { get; set; }
        public string Napravlenie { get; set; }
        public string Uslspeed { get; set; }
        public string GlobalId { get; set; }
    }

}