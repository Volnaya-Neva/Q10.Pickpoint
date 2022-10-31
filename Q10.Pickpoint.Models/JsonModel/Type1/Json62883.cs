namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json62883 : JsonType1
{
    public class Properties
    {
        public string Name { get; set; }
        public string Aeroexpress { get; set; }
        public Aeroexpressstation AeroexpressStation { get; set; }
        public string AeroexpressTerminal { get; set; }
        public string AeroexpressTicketWindow { get; set; }
        public string AeroexpressTicketAutomat { get; set; }
        public string AeroexpressWorkingHours { get; set; }
        public string GlobalId { get; set; }
    }

    public class Aeroexpressstation
    {
        public string GlobalId { get; set; }
        public string Value { get; set; }
    }

}