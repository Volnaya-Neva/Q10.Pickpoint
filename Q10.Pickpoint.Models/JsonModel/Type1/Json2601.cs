namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json2601 : JsonType1
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
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public string Inn { get; set; }
        public string Okpo { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string Category { get; set; }
        public string Specialization { get; set; }
        public string Okved { get; set; }
        public string OkvedDescription { get; set; }
        public long GlobalId { get; set; }
    }

}