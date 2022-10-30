namespace Q10.Pickpoint.Models.JsonModel;

public class Json3101
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
        public string Category { get; set; }
        public string WebSite { get; set; }
        public string ClarificationOfWorkingHours { get; set; }
        public string ChiefName { get; set; }
        public string ChiefPosition { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string Location { get; set; }
        public string HistoricalInfo { get; set; }
        public string Parking { get; set; }
        public string GettingThere { get; set; }
        public long GlobalId { get; set; }
    }

}