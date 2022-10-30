namespace Q10.Pickpoint.Models.JsonModel.Type2;

public class Json62441 : JsonType2
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
        public float[][] Coordinates { get; set; }
        public string Type { get; set; }
    }

    public class Properties
    {
        public string Customer { get; set; }
        public string WorkReason { get; set; }
        public string ActualStartDate { get; set; }
        public string ActualEndDate { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string AddressOfNearbyBuilding { get; set; }
        public string WorkPlaceDescription { get; set; }
        public long GlobalId { get; set; }
    }

}