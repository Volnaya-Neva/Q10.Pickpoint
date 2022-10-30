namespace Q10.Pickpoint.Models.JsonModel;

public class Json2193
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
        public string AdmAreaen { get; set; }
        public string Districten { get; set; }
        public string Locationen { get; set; }
        public string ClarificationOfLocationen { get; set; }
        public string OperOrgNameen { get; set; }
        public string OperOrgWebsiteen { get; set; }
        public long GlobalId { get; set; }
    }

}