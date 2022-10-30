namespace Q10.Pickpoint.Models.JsonModel;

public class Json60869
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
        public string SculpName { get; set; }
        public string Photo { get; set; }
        public string Author { get; set; }
        public int? ManufactYear { get; set; }
        public string Material { get; set; }
        public string Description { get; set; }
        public string LocationPlace { get; set; }
        public long GlobalId { get; set; }
    }

}