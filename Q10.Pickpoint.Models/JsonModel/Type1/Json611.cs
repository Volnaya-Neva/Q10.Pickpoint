namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json611 : JsonType1
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
        public string CommonName { get; set; }
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string ChiefName { get; set; }
        public string ChiefPosition { get; set; }
        public string ClarificationOfWorkingHours { get; set; }
        public string OpenDate { get; set; }
        public float CenterArea { get; set; }
        public int WindowCount { get; set; }
        public string WebSite { get; set; }
        public long GlobalId { get; set; }
    }

}