namespace Q10.Pickpoint.Models.JsonModel;

public class Json2682
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
        public string District { get; set; }
        public string AdmArea { get; set; }
        public string MetroStation { get; set; }
        public string LocationDescription { get; set; }
        public string HelpPhone { get; set; }
        public string VaccinationMandatoryConditions { get; set; }
        public long GlobalId { get; set; }
    }

}