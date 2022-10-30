namespace Q10.Pickpoint.Models.JsonModel;

public class Json6555
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
        public float[][] Coordinates { get; set; }
        public string Type { get; set; }
    }

    public class Properties
    {
        public string ChiefNameen { get; set; }
        public string ClarificationWorkingHoursen { get; set; }
        public string WebSiteen { get; set; }
        public string ShortNameen { get; set; }
        public string FullNameen { get; set; }
        public string CommonNameen { get; set; }
        public string ChiefPositionen { get; set; }
        public int GlobalId { get; set; }
    }

}