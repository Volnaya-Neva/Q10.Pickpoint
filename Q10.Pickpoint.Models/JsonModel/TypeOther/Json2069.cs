namespace Q10.Pickpoint.Models.JsonModel.TypeOther;

public class Json2069 : JsonType4
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
        public object[][][] Coordinates { get; set; }
        public string Type { get; set; }
    }

    public class Properties
    {
        public string Name { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string Location { get; set; }
        public string Crossing { get; set; }
        public int YearOfComissioning { get; set; }
        public string GlobalId { get; set; }
    }

}