namespace Q10.Pickpoint.Models.JsonModel;

public class Json918
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
        public int StationCapacity { get; set; }
        public object BikeParkingSlotsAmount { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string Location { get; set; }
        public string ClarificationOfLocation { get; set; }
        public string OperOrgName { get; set; }
        public string OperOrgWebsite { get; set; }
        public string Photo { get; set; }
        public long GlobalId { get; set; }
    }

}