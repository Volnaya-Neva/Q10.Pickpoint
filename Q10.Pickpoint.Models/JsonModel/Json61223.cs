namespace Q10.Pickpoint.Models.JsonModel;

public class Json61223
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
        public string NameObservationPlatform { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string RefineLocation { get; set; }
        public int NumberFreeBinoculars { get; set; }
        public int NumberPaidBinoculars { get; set; }
        public int GlobalId { get; set; }
    }

}