namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json1328 : JsonType1
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
        public string ObjectNameEn { get; set; }
        public string NameWinterEn { get; set; }
        public string AdmAreaEn { get; set; }
        public string DistrictEn { get; set; }
        public string AddressEn { get; set; }
        public string EmailEn { get; set; }
        public string WebSiteEn { get; set; }
        public string HelpPhoneEn { get; set; }
        public string HelpPhoneExtensionEn { get; set; }
        public string ClarificationOfWorkingHoursWinterEn { get; set; }
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
        public string UsagePeriodWinterEn { get; set; }
        public string LightingEn { get; set; }
        public string SurfaceTypeWinterEn { get; set; }
        public int SeatsEn { get; set; }
        public string PaidEn { get; set; }
        public string PaidCommentsEn { get; set; }
        public object DisabilityFriendlyEn { get; set; }
        public string ServicesWinterEn { get; set; }
        public int GlobalId { get; set; }
        public int PhotoWinterEnisDeleted0 { get; set; }
        public int PhotoWinterEnGlobalId0 { get; set; }
        public string PhotoWinterEnPhotoEn0 { get; set; }
        public int WorkingHoursWinterEnisDeleted0 { get; set; }
        public int WorkingHoursWinterEnGlobalId0 { get; set; }
        public string WorkingHoursWinterEnDayOfWeekEn0 { get; set; }
        public string WorkingHoursWinterEnHoursEn0 { get; set; }
        public int WorkingHoursWinterEnisDeleted1 { get; set; }
        public int WorkingHoursWinterEnGlobalId1 { get; set; }
        public string WorkingHoursWinterEnDayOfWeekEn1 { get; set; }
        public string WorkingHoursWinterEnHoursEn1 { get; set; }
        public int WorkingHoursWinterEnisDeleted2 { get; set; }
        public int WorkingHoursWinterEnGlobalId2 { get; set; }
        public string WorkingHoursWinterEnDayOfWeekEn2 { get; set; }
        public string WorkingHoursWinterEnHoursEn2 { get; set; }
        public int WorkingHoursWinterEnisDeleted3 { get; set; }
        public int WorkingHoursWinterEnGlobalId3 { get; set; }
        public string WorkingHoursWinterEnDayOfWeekEn3 { get; set; }
        public string WorkingHoursWinterEnHoursEn3 { get; set; }
        public int WorkingHoursWinterEnisDeleted4 { get; set; }
        public int WorkingHoursWinterEnGlobalId4 { get; set; }
        public string WorkingHoursWinterEnDayOfWeekEn4 { get; set; }
        public string WorkingHoursWinterEnHoursEn4 { get; set; }
        public int WorkingHoursWinterEnisDeleted5 { get; set; }
        public int WorkingHoursWinterEnGlobalId5 { get; set; }
        public string WorkingHoursWinterEnDayOfWeekEn5 { get; set; }
        public string WorkingHoursWinterEnHoursEn5 { get; set; }
        public int WorkingHoursWinterEnisDeleted6 { get; set; }
        public int WorkingHoursWinterEnGlobalId6 { get; set; }
        public string WorkingHoursWinterEnDayOfWeekEn6 { get; set; }
        public string WorkingHoursWinterEnHoursEn6 { get; set; }
        public int DimensionsWinterEnisDeleted0 { get; set; }
        public int DimensionsWinterEnGlobalId0 { get; set; }
        public float DimensionsWinterEnSquareEn0 { get; set; }
        public float DimensionsWinterEnLengthEn0 { get; set; }
        public int DimensionsWinterEnWidthEn0 { get; set; }
        public object DimensionsWinterEnDepthEn0 { get; set; }
    }

}