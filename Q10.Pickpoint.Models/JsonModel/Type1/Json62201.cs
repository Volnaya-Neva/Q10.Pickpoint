namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json62201 : JsonType1
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
        public string Name { get; set; }
        public string Transliteration { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string LongitudeWgs84 { get; set; }
        public string LatitudeWgs84 { get; set; }
        public string Aeroexpress { get; set; }
        public string AeroexpressTerminal { get; set; }
        public string AeroexpressTicketWindow { get; set; }
        public string AeroexpressTicketAutomat { get; set; }
        public string WiFiAvailability { get; set; }
        public string BabyCareRoom { get; set; }
        public string WebSite { get; set; }
        public string ExtraInfo { get; set; }
        public int GlobalId { get; set; }
    }

}