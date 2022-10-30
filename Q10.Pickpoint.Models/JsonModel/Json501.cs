namespace Q10.Pickpoint.Models.JsonModel;

public class Json501
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
        public object Shortname { get; set; }
        public object Okrug { get; set; }
        public object Vedom { get; set; }
        public string Glavnoelpu { get; set; }
        public string Adres { get; set; }
        public string Telnomer { get; set; }
        public string Info { get; set; }
        public string Type { get; set; }
        public object Special { get; set; }
        public object Lekobesp { get; set; }
        public object Recept { get; set; }
        public string Хwgs { get; set; }
        public string Ywgs { get; set; }
        public string GlobalId { get; set; }
    }

}