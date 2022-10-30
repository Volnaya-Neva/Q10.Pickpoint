namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json2452 : JsonType1
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
        public int Year { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public float EstimatedindexValue { get; set; }
        public string PollutionCategory { get; set; }
        public string PollutionLevel { get; set; }
        public long GlobalId { get; set; }
    }

}