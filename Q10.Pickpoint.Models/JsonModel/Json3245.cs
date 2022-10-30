namespace Q10.Pickpoint.Models.JsonModel;

public class Json3245
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
        public string StationaryObjectName { get; set; }
        public string ObjectType { get; set; }
        public Parkname ParkName { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public float FacilityArea { get; set; }
        public long GlobalId { get; set; }
    }

    public class Parkname
    {
        public int GlobalId { get; set; }
        public string Value { get; set; }
    }

}