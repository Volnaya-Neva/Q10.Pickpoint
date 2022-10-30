namespace Q10.Pickpoint.Models.JsonModel;

public class Json60543
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
        public object MetroStationen { get; set; }
        public object AdmAreaen { get; set; }
        public object Districten { get; set; }
        public string LocationDescriptionen { get; set; }
        public string HelpPhoneen { get; set; }
        public string VaccinationMandatoryConditionsen { get; set; }
        public long GlobalId { get; set; }
    }

}