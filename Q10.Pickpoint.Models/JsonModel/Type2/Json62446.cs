namespace Q10.Pickpoint.Models.JsonModel.Type2;

public class Json62446 : JsonType2
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
        public object Customeren { get; set; }
        public string ActualStartDateen { get; set; }
        public object WorkReasonen { get; set; }
        public string ActualEndDateen { get; set; }
        public object AdmAreaen { get; set; }
        public object Districten { get; set; }
        public string AddressOfNearbyBuildingen { get; set; }
        public string WorkPlaceDescriptionen { get; set; }
        public long GlobalId { get; set; }
    }

}