namespace Q10.Pickpoint.Models.JsonModel;

public class Json913
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
        public string NameSummer { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string WebSite { get; set; }
        public string HelpPhone { get; set; }
        public string HelpPhoneExtension { get; set; }
        public string ClarificationOfWorkingHoursSummer { get; set; }
        public string HasEquipmentRental { get; set; }
        public string HasTechService { get; set; }
        public string HasDressingRoom { get; set; }
        public string HasEatery { get; set; }
        public string HasToilet { get; set; }
        public string HasWifi { get; set; }
        public string HasCashMachine { get; set; }
        public string HasFirstAidPost { get; set; }
        public string HasMusic { get; set; }
        public string UsagePeriodSummer { get; set; }
        public string Lighting { get; set; }
        public string SurfaceTypeSummer { get; set; }
        public int Seats { get; set; }
        public string Paid { get; set; }
        public string DisabilityFriendly { get; set; }
        public string ServicesSummer { get; set; }
        public long GlobalId { get; set; }
    }

}