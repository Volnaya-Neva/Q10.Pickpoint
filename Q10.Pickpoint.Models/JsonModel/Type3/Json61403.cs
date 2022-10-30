namespace Q10.Pickpoint.Models.JsonModel.Type3;

public class Json61403 : JsonType3
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
        public int BlockRegNumber { get; set; }
        public string AdmArea { get; set; }
        public string Settlement { get; set; }
        public int BlockNumber { get; set; }
        public string RegulatoryName { get; set; }
        public string AbbreviatedRegulatoryName { get; set; }
        public string FiasGuid { get; set; }
        public string FiasParentGuid { get; set; }
        public int GlobalId { get; set; }
    }

}