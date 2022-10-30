namespace Q10.Pickpoint.Models.JsonModel;

public class Json3446
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
        public string ObjectNameen { get; set; }
        public string NameSummeren { get; set; }
        public object AdmAreaen { get; set; }
        public object Districten { get; set; }
        public string Addressen { get; set; }
        public string Emailen { get; set; }
        public string WebSiteen { get; set; }
        public string HelpPhoneen { get; set; }
        public string HelpPhoneExtensionen { get; set; }
        public string ClarificationOfWorkingHoursSummeren { get; set; }
        public string HasEquipmentRentalen { get; set; }
        public string EquipmentRentalCommentsen { get; set; }
        public string HasTechServiceen { get; set; }
        public string TechServiceCommentsen { get; set; }
        public string HasDressingRoomen { get; set; }
        public string HasEateryen { get; set; }
        public string HasToileten { get; set; }
        public string HasWifien { get; set; }
        public string HasCashMachineen { get; set; }
        public string HasFirstAidPosten { get; set; }
        public string HasMusicen { get; set; }
        public string UsagePeriodSummeren { get; set; }
        public object Lightingen { get; set; }
        public object SurfaceTypeSummeren { get; set; }
        public int Seatsen { get; set; }
        public object Paiden { get; set; }
        public string PaidCommentsen { get; set; }
        public object DisabilityFriendlyen { get; set; }
        public object ServicesSummeren { get; set; }
        public long GlobalId { get; set; }
    }

}