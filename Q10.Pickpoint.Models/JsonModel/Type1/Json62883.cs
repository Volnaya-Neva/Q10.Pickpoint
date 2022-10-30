namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json62883 : JsonType1
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
        public string Aeroexpress { get; set; }
        public Aeroexpressstation AeroexpressStation { get; set; }
        public string AeroexpressTerminal { get; set; }
        public string AeroexpressTicketWindow { get; set; }
        public string AeroexpressTicketAutomat { get; set; }
        public string AeroexpressWorkingHours { get; set; }
        public int GlobalId { get; set; }
    }

    public class Aeroexpressstation
    {
        public int GlobalId { get; set; }
        public string Value { get; set; }
    }

}