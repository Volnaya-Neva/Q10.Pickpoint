namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json567 : JsonType1
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
        public string Okrug { get; set; }
        public string Rayon { get; set; }
        public string Formofincorporation { get; set; }
        public string Submission { get; set; }
        public string Tipuchrezhdeniya { get; set; }
        public string Viduchrezhdeniya { get; set; }
        public string Telephone { get; set; }
        public string Website { get; set; }
        public string Email { get; set; }
        public string X { get; set; }
        public string Y { get; set; }
        public string GlobalId { get; set; }
    }

}