namespace Q10.Pickpoint.Models.JsonModel;

public class Json61801
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
        public string ObjectType { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public Nameofpark NameOfPark { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string WorkingHours { get; set; }
        public string PaidService { get; set; }
        public string InventoryRental { get; set; }
        public string HasDressingRoom { get; set; }
        public string SharpeningSkates { get; set; }
        public string HireSkatersAssistants { get; set; }
        public int? Square { get; set; }
        public float? Length { get; set; }
        public string LightingAvailability { get; set; }
        public int GlobalId { get; set; }
    }

    public class Nameofpark
    {
        public int GlobalId { get; set; }
        public string Value { get; set; }
    }

}