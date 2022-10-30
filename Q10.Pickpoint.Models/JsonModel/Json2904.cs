namespace Q10.Pickpoint.Models.JsonModel;

public class Json2904
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
        public object AdmAreaen { get; set; }
        public object Districten { get; set; }
        public string Addressen { get; set; }
        public string WebSiteen { get; set; }
        public int Iden { get; set; }
        public string WorkHoursClarificationen { get; set; }
        public int GlobalId { get; set; }
    }

}