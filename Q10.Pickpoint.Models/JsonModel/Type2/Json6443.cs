namespace Q10.Pickpoint.Models.JsonModel.Type2;

public class Json6443 : JsonType2
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
        public string CategoryEn { get; set; }
        public string CommonNameEn { get; set; }
        public string FullNameEn { get; set; }
        public string ShortNameEn { get; set; }
        public string ChiefPositionEn { get; set; }
        public string ChiefNameEn { get; set; }
        public string ClarificationWorkingHoursEn { get; set; }
        public string WebSiteEn { get; set; }
        public long GlobalId { get; set; }
        public int OrgInfoEnisDeleted0 { get; set; }
        public OrginfoEnchiefphoneEn0[] OrgInfoEnChiefPhoneEn0 { get; set; }
        public string OrgInfoEnFullNameEn0 { get; set; }
        public string OrgInfoEnInnEn0 { get; set; }
        public string OrgInfoEnKppEn0 { get; set; }
        public string OrgInfoEnOgrnEn0 { get; set; }
        public string OrgInfoEnLegalAddressEn0 { get; set; }
        public string OrgInfoEnChiefNameEn0 { get; set; }
        public string OrgInfoEnChiefPositionEn0 { get; set; }
        public int OrgInfoEnGlobalId0 { get; set; }
        public int ObjectAddressEnisDeleted0 { get; set; }
        public string ObjectAddressEnAdmAreaEn0 { get; set; }
        public string ObjectAddressEnDistrictEn0 { get; set; }
        public string ObjectAddressEnPostalCodeEn0 { get; set; }
        public string ObjectAddressEnAddressEn0 { get; set; }
        public string ObjectAddressEnSocialServicesEn0 { get; set; }
        public ObjectaddressEnavailabilityEn0[] ObjectAddressEnAvailabilityEn0 { get; set; }
        public int ObjectAddressEnGlobalId0 { get; set; }
        public int PublicPhoneEnisDeleted0 { get; set; }
        public string PublicPhoneEnPublicPhoneEn0 { get; set; }
        public int PublicPhoneEnGlobalId0 { get; set; }
        public int WorkingHoursEnisDeleted0 { get; set; }
        public string WorkingHoursEnDayWeekEn0 { get; set; }
        public string WorkingHoursEnWorkHoursEn0 { get; set; }
        public int WorkingHoursEnGlobalId0 { get; set; }
        public int WorkingHoursEnisDeleted1 { get; set; }
        public string WorkingHoursEnDayWeekEn1 { get; set; }
        public string WorkingHoursEnWorkHoursEn1 { get; set; }
        public int WorkingHoursEnGlobalId1 { get; set; }
        public int WorkingHoursEnisDeleted2 { get; set; }
        public string WorkingHoursEnDayWeekEn2 { get; set; }
        public string WorkingHoursEnWorkHoursEn2 { get; set; }
        public int WorkingHoursEnGlobalId2 { get; set; }
        public int WorkingHoursEnisDeleted3 { get; set; }
        public string WorkingHoursEnDayWeekEn3 { get; set; }
        public string WorkingHoursEnWorkHoursEn3 { get; set; }
        public int WorkingHoursEnGlobalId3 { get; set; }
        public int WorkingHoursEnisDeleted4 { get; set; }
        public string WorkingHoursEnDayWeekEn4 { get; set; }
        public string WorkingHoursEnWorkHoursEn4 { get; set; }
        public int WorkingHoursEnGlobalId4 { get; set; }
        public int WorkingHoursEnisDeleted5 { get; set; }
        public string WorkingHoursEnDayWeekEn5 { get; set; }
        public string WorkingHoursEnWorkHoursEn5 { get; set; }
        public int WorkingHoursEnGlobalId5 { get; set; }
        public int WorkingHoursEnisDeleted6 { get; set; }
        public string WorkingHoursEnDayWeekEn6 { get; set; }
        public string WorkingHoursEnWorkHoursEn6 { get; set; }
        public int WorkingHoursEnGlobalId6 { get; set; }
        public int OrgInfoEnisDeleted1 { get; set; }
        public OrginfoEnchiefphoneEn1[] OrgInfoEnChiefPhoneEn1 { get; set; }
        public string OrgInfoEnFullNameEn1 { get; set; }
        public string OrgInfoEnInnEn1 { get; set; }
        public string OrgInfoEnKppEn1 { get; set; }
        public string OrgInfoEnOgrnEn1 { get; set; }
        public string OrgInfoEnLegalAddressEn1 { get; set; }
        public string OrgInfoEnChiefNameEn1 { get; set; }
        public string OrgInfoEnChiefPositionEn1 { get; set; }
        public int OrgInfoEnGlobalId1 { get; set; }
        public int ObjectAddressEnisDeleted1 { get; set; }
        public string ObjectAddressEnAdmAreaEn1 { get; set; }
        public string ObjectAddressEnDistrictEn1 { get; set; }
        public string ObjectAddressEnPostalCodeEn1 { get; set; }
        public string ObjectAddressEnAddressEn1 { get; set; }
        public string ObjectAddressEnSocialServicesEn1 { get; set; }
        public ObjectaddressEnavailabilityEn1[] ObjectAddressEnAvailabilityEn1 { get; set; }
        public int ObjectAddressEnGlobalId1 { get; set; }
        public int PublicPhoneEnisDeleted1 { get; set; }
        public string PublicPhoneEnPublicPhoneEn1 { get; set; }
        public int PublicPhoneEnGlobalId1 { get; set; }
        public int PublicPhoneEnisDeleted2 { get; set; }
        public string PublicPhoneEnPublicPhoneEn2 { get; set; }
        public int PublicPhoneEnGlobalId2 { get; set; }
        public int PublicPhoneEnisDeleted3 { get; set; }
        public string PublicPhoneEnPublicPhoneEn3 { get; set; }
        public int PublicPhoneEnGlobalId3 { get; set; }
        public int PublicPhoneEnisDeleted4 { get; set; }
        public string PublicPhoneEnPublicPhoneEn4 { get; set; }
        public int PublicPhoneEnGlobalId4 { get; set; }
        public int PublicPhoneEnisDeleted5 { get; set; }
        public string PublicPhoneEnPublicPhoneEn5 { get; set; }
        public int PublicPhoneEnGlobalId5 { get; set; }
        public int WorkingHoursEnisDeleted7 { get; set; }
        public string WorkingHoursEnDayWeekEn7 { get; set; }
        public string WorkingHoursEnWorkHoursEn7 { get; set; }
        public int WorkingHoursEnGlobalId7 { get; set; }
        public int WorkingHoursEnisDeleted8 { get; set; }
        public string WorkingHoursEnDayWeekEn8 { get; set; }
        public string WorkingHoursEnWorkHoursEn8 { get; set; }
        public int WorkingHoursEnGlobalId8 { get; set; }
        public int WorkingHoursEnisDeleted9 { get; set; }
        public string WorkingHoursEnDayWeekEn9 { get; set; }
        public string WorkingHoursEnWorkHoursEn9 { get; set; }
        public int WorkingHoursEnGlobalId9 { get; set; }
        public int WorkingHoursEnisDeleted10 { get; set; }
        public string WorkingHoursEnDayWeekEn10 { get; set; }
        public string WorkingHoursEnWorkHoursEn10 { get; set; }
        public int WorkingHoursEnGlobalId10 { get; set; }
        public int WorkingHoursEnisDeleted11 { get; set; }
        public string WorkingHoursEnDayWeekEn11 { get; set; }
        public string WorkingHoursEnWorkHoursEn11 { get; set; }
        public int WorkingHoursEnGlobalId11 { get; set; }
        public int WorkingHoursEnisDeleted12 { get; set; }
        public string WorkingHoursEnDayWeekEn12 { get; set; }
        public string WorkingHoursEnWorkHoursEn12 { get; set; }
        public int WorkingHoursEnGlobalId12 { get; set; }
        public int WorkingHoursEnisDeleted13 { get; set; }
        public string WorkingHoursEnDayWeekEn13 { get; set; }
        public string WorkingHoursEnWorkHoursEn13 { get; set; }
        public int WorkingHoursEnGlobalId13 { get; set; }
    }

    public class OrginfoEnchiefphoneEn0
    {
        public int IsDeleted { get; set; }
        public int GlobalId { get; set; }
        public string ChiefPhoneEn { get; set; }
    }

    public class ObjectaddressEnavailabilityEn0
    {
        public int IsDeleted { get; set; }
        public int GlobalId { get; set; }
        public string AvailableKEn { get; set; }
        public string AvailableOEn { get; set; }
        public string AvailableZEn { get; set; }
        public string AvailableSEn { get; set; }
        public AvailableElementEn[] AvailableElementEn { get; set; }
    }

    public class AvailableElementEn
    {
        public int IsDeleted { get; set; }
        public int GlobalId { get; set; }
        public string GroupMgnEn { get; set; }
        public string AreaMgnEn { get; set; }
        public string ElementMgnEn { get; set; }
        public string AvailableDegreeEn { get; set; }
        public string AvailableIndexEn { get; set; }
    }

    public class OrginfoEnchiefphoneEn1
    {
        public int IsDeleted { get; set; }
        public int GlobalId { get; set; }
        public string ChiefPhoneEn { get; set; }
    }

    public class ObjectaddressEnavailabilityEn1
    {
        public int IsDeleted { get; set; }
        public int GlobalId { get; set; }
        public string AvailableKEn { get; set; }
        public string AvailableOEn { get; set; }
        public string AvailableZEn { get; set; }
        public string AvailableSEn { get; set; }
        public AvailableElementEn1[] AvailableElementEn { get; set; }
    }

    public class AvailableElementEn1
    {
        public int IsDeleted { get; set; }
        public int GlobalId { get; set; }
        public string GroupMgnEn { get; set; }
        public string AreaMgnEn { get; set; }
        public string ElementMgnEn { get; set; }
        public string AvailableDegreeEn { get; set; }
        public string AvailableIndexEn { get; set; }
    }

}