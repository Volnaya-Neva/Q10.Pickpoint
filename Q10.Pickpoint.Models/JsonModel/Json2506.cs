namespace Q10.Pickpoint.Models.JsonModel;

public class Json2506
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
        public string Nameen { get; set; }
        public string IsNetObjecten { get; set; }
        public string OperatingCompanyen { get; set; }
        public string TypeServiceen { get; set; }
        public string AdmAreaen { get; set; }
        public string Districten { get; set; }
        public string Addressen { get; set; }
        public string ClarificationOfWorkingHoursen { get; set; }
        public int GlobalId { get; set; }
    }

}