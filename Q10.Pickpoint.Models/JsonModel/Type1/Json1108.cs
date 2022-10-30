namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json1108 : JsonType1
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
        public string Okrug { get; set; }
        public string Address { get; set; }
        public string Unom { get; set; }
        public string Floor { get; set; }
        public string Square { get; set; }
        public string Startarende { get; set; }
        public string Use { get; set; }
        public string Dateauction { get; set; }
        public string Adresauction { get; set; }
        public string Sait { get; set; }
        public string Winner { get; set; }
        public string Resultarende { get; set; }
        public string XWgs84 { get; set; }
        public string YWgs84 { get; set; }
        public string GlobalId { get; set; }
    }

}