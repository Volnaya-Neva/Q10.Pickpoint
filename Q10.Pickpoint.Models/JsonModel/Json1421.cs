namespace Q10.Pickpoint.Models.JsonModel;

public class Json1421
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
        public string NumberOfParkingMeter { get; set; }
        public string ParkingZoneNumber { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string StreetName { get; set; }
        public string Location { get; set; }
        public long GlobalId { get; set; }
    }

}