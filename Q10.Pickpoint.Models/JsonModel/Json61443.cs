namespace Q10.Pickpoint.Models.JsonModel;

public class Json61443
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
        public string NameCourtDistrict { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string NameMagistrate { get; set; }
        public string WebSite { get; set; }
        public string ClarificationOfWorkingHours { get; set; }
        public string ClarificationOfScheduleReception { get; set; }
        public int GlobalId { get; set; }
    }

}