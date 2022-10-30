namespace Q10.Pickpoint.Models.JsonModel.Type3;

public class Json897 : JsonType3
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
        public float[][][] Coordinates { get; set; }
        public string Type { get; set; }
    }

    public class Properties
    {
        public string Name { get; set; }
        public string PortionName { get; set; }
        public float Width { get; set; }
        public string Location { get; set; }
        public string OperOrgName { get; set; }
        public string ObjectOperOrgPhone { get; set; }
        public long GlobalId { get; set; }
        public string Type { get; set; }
        public string DepartmentalAffiliation { get; set; }
    }

}