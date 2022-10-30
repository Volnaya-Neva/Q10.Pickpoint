namespace Q10.Pickpoint.Models.JsonModel;

public class Json1200
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
        public string ShortName { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public int Index { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string ClarificationOfVisitingHours { get; set; }
        public string ChiefName { get; set; }
        public string ClarificationOfDocumentsIssuanceHours { get; set; }
        public string ExtraInfo { get; set; }
        public int GlobalId { get; set; }
    }

}