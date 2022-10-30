namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json62321 : JsonType1
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
        public string LocationDescription { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string ClarificationOfLocation { get; set; }
        public string PointPhoto { get; set; }
        public string ClarificationOfWorkingHours { get; set; }
        public string OpenDate { get; set; }
        public string CloseDate { get; set; }
        public string ExtraInfo { get; set; }
        public int GlobalId { get; set; }
    }

}