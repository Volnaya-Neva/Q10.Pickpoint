namespace Q10.Pickpoint.Models.JsonModel;

public class Json3249
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
        public string NameOrg { get; set; }
        public string ChiefName { get; set; }
        public string Position { get; set; }
        public string Address { get; set; }
        public string WebSite { get; set; }
        public int GlobalId { get; set; }
    }

}