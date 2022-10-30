namespace Q10.Pickpoint.Models.JsonModel;

public class Json2184
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
        public string CommonNameen { get; set; }
        public string FullNameen { get; set; }
        public string ShortNameen { get; set; }
        public string InNen { get; set; }
        public string KpPen { get; set; }
        public string OgrNen { get; set; }
        public object AdmAreaen { get; set; }
        public object Districten { get; set; }
        public string Addressen { get; set; }
        public string ChiefNameen { get; set; }
        public object ChiefPositionen { get; set; }
        public string ClarificationOfWorkingHoursen { get; set; }
        public string OpenDateen { get; set; }
        public object ExtraServicesen { get; set; }
        public float CenterAreaen { get; set; }
        public int WindowCounten { get; set; }
        public string WebSiteen { get; set; }
        public string UnoMen { get; set; }
        public long GlobalId { get; set; }
    }

}