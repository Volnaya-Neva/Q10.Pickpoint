namespace Q10.Pickpoint.Models.JsonModel;

public class Json2216
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
        public int Iden { get; set; }
        public string Nameen { get; set; }
        public string Photoen { get; set; }
        public object AdmAreaen { get; set; }
        public object Districten { get; set; }
        public string Locationen { get; set; }
        public string RegistrationNumberen { get; set; }
        public object Stateen { get; set; }
        public object LocationTypeen { get; set; }
        public long GlobalId { get; set; }
    }

}