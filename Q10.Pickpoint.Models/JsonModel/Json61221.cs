namespace Q10.Pickpoint.Models.JsonModel;

public class Json61221
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
        public string FullName { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string FullAvailable { get; set; }
        public string Availableo { get; set; }
        public string Availablez { get; set; }
        public string Availables { get; set; }
        public string Availablek { get; set; }
        public string PresenceParking { get; set; }
        public string PresenceWc { get; set; }
        public string PresenceRoom { get; set; }
        public int GlobalId { get; set; }
    }

}