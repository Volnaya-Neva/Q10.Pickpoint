namespace Q10.Pickpoint.Models.JsonModel.Type2;

public class Json493 : JsonType2
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
        public string CommonName { get; set; }
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public string ChiefOrg { get; set; }
        public string ChiefName { get; set; }
        public string ChiefPosition { get; set; }
        public string ClarificationOfWorkingHours { get; set; }
        public string WebSite { get; set; }
        public object ObjectCategory { get; set; }
        public long GlobalId { get; set; }
    }
}