namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json1881 : JsonType1
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
        public string Name { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string MetroStation { get; set; }
        public string MetroLine { get; set; }
        public string WiFiAvailability { get; set; }
        public string BabyCareRoom { get; set; }
        public string SanitationFacilities { get; set; }
        public string WebSite { get; set; }
        public string BusDestination { get; set; }
        public string LocationComment { get; set; }
        public int GlobalId { get; set; }
    }

}