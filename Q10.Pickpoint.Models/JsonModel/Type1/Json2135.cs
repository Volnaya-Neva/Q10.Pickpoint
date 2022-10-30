namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json2135 : JsonType1
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
        public int RegisterIdEn { get; set; }
        public string ObjectNameEn { get; set; }
        public string NameSummerEn { get; set; }
        public object AdmAreaEn { get; set; }
        public object DistrictEn { get; set; }
        public string AddressEn { get; set; }
        public string EmailEn { get; set; }
        public string WebSiteEn { get; set; }
        public string HelpPhoneEn { get; set; }
        public string HelpPhoneExtensionEn { get; set; }
        public string ClarificationOfWorkingHoursSummerEn { get; set; }
        public string HasEquipmentRentalEn { get; set; }
        public string EquipmentRentalCommentsEn { get; set; }
        public string HasTechServiceEn { get; set; }
        public string TechServiceCommentsEn { get; set; }
        public string HasDressingRoomEn { get; set; }
        public string HasEateryEn { get; set; }
        public string HasToiletEn { get; set; }
        public string HasWifiEn { get; set; }
        public string HasCashMachineEn { get; set; }
        public string HasFirstAidPostEn { get; set; }
        public string HasMusicEn { get; set; }
        public string UsagePeriodSummerEn { get; set; }
        public object LightingEn { get; set; }
        public object SurfaceTypeSummerEn { get; set; }
        public int SeatsEn { get; set; }
        public object PaidEn { get; set; }
        public string PaidCommentsEn { get; set; }
        public object DisabilityFriendlyEn { get; set; }
        public object ServicesSummerEn { get; set; }
        public object DatasetSummerEn { get; set; }
        public long GlobalId { get; set; }
    }

}