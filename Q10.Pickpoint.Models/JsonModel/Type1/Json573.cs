namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json573 : JsonType1
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
        public string Adress { get; set; }
        public string Okryg { get; set; }
        public string Rayon { get; set; }
        public string Orgpravforma { get; set; }
        public string Podchinenie { get; set; }
        public string Tipychregdenia { get; set; }
        public string Vidychregdenia { get; set; }
        public string Telefon { get; set; }
        public string Sait { get; set; }
        public string Email { get; set; }
        public string X { get; set; }
        public string Y { get; set; }
        public string GlobalId { get; set; }
    }

}