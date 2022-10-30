namespace Q10.Pickpoint.Models.JsonModel.Type3;

public class Json62601 : JsonType3
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
        public string Street { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public int SpeedLimit { get; set; }
        public string TransportLimit { get; set; }
        public string TimeLimit { get; set; }
        public string RoadConditionsLimit { get; set; }
        public string CommissioningDate { get; set; }
        public long GlobalId { get; set; }
    }

}