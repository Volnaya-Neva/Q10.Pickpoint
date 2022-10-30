namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json597 : JsonType1
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
        public string Area { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string ChiefName { get; set; }
        public string ChiefPosition { get; set; }
        public string PublicPhone { get; set; }
        public string WorkingHours { get; set; }
        public string ClarificationOfWorkingHours { get; set; }
        public string WebSite { get; set; }
        public string AddressUnom { get; set; }
        public string Pointx { get; set; }
        public string Pointy { get; set; }
        public string GlobalId { get; set; }
    }

}