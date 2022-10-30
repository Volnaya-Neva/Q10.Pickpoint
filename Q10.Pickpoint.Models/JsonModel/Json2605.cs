namespace Q10.Pickpoint.Models.JsonModel;

public class Json2605
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
        public object AdmAreaen { get; set; }
        public object Districten { get; set; }
        public string Addressen { get; set; }
        public object Jurisdictionen { get; set; }
        public string JudgeNameen { get; set; }
        public string Phoneen { get; set; }
        public string Faxen { get; set; }
        public string Emailen { get; set; }
        public long GlobalId { get; set; }
    }

}