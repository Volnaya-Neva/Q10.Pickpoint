namespace Q10.Pickpoint.Models.JsonModel.Type3;

public class Json623 : JsonType3
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
        public string ParkingName { get; set; }
        public string ParkingZoneNumber { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public int CarCapacity { get; set; }
        public int CarCapacityDisabled { get; set; }
        public int GlobalId { get; set; }
    }

}