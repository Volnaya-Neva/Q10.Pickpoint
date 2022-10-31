namespace Q10.Pickpoint.Models.JsonModel.Type2;

public class Json1257 : JsonType2
{
    public class Properties
    {
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public string ChiefName { get; set; }
        public string ChiefPosition { get; set; }
        public string ChiefGender { get; set; }
        public string PaidServiceInfo { get; set; }
        public string ClarificationWorkingHours { get; set; }
        public string Extrainfo { get; set; }
        public string AgeRestriction { get; set; }
        public string GlobalId { get; set; }
        public int OrgInfoisDeleted0 { get; set; }
        public string OrgInfoFullName0 { get; set; }
        public Orginfochiefphone0[] OrgInfoChiefPhone0 { get; set; }
        public string OrgInfoInn0 { get; set; }
        public string OrgInfoKpp0 { get; set; }
        public string OrgInfoOgrn0 { get; set; }
        public string OrgInfoLegalAddress0 { get; set; }
        public string OrgInfoChiefName0 { get; set; }
        public object OrgInfoChiefPosition0 { get; set; }
        public object OrgInfoChiefGender0 { get; set; }
        public int OrgInfoGlobalId0 { get; set; }
        public int ObjectAddressisDeleted0 { get; set; }
        public object ObjectAddressAdmArea0 { get; set; }
        public object ObjectAddressDistrict0 { get; set; }
        public string ObjectAddressPostalCode0 { get; set; }
        public string ObjectAddressAddress0 { get; set; }
        public Objectaddressavailability0[] ObjectAddressAvailability0 { get; set; }
        public string ObjectAddressExtrainfo0 { get; set; }
        public int ObjectAddressGlobalId0 { get; set; }
        public int ChiefPhoneisDeleted0 { get; set; }
        public string ChiefPhoneChiefPhone0 { get; set; }
        public int ChiefPhoneGlobalId0 { get; set; }
        public int PublicPhoneisDeleted0 { get; set; }
        public string PublicPhonePublicPhone0 { get; set; }
        public int PublicPhoneGlobalId0 { get; set; }
        public int FaxisDeleted0 { get; set; }
        public string FaxFax0 { get; set; }
        public int FaxGlobalId0 { get; set; }
        public int EmailisDeleted0 { get; set; }
        public string EmailEmail0 { get; set; }
        public int EmailGlobalId0 { get; set; }
        public int WorkingHoursisDeleted0 { get; set; }
        public object WorkingHoursDayWeek0 { get; set; }
        public string WorkingHoursWorkHours0 { get; set; }
        public int WorkingHoursGlobalId0 { get; set; }
        public int WorkingHoursisDeleted1 { get; set; }
        public object WorkingHoursDayWeek1 { get; set; }
        public string WorkingHoursWorkHours1 { get; set; }
        public int WorkingHoursGlobalId1 { get; set; }
        public int WorkingHoursisDeleted2 { get; set; }
        public object WorkingHoursDayWeek2 { get; set; }
        public string WorkingHoursWorkHours2 { get; set; }
        public int WorkingHoursGlobalId2 { get; set; }
        public int WorkingHoursisDeleted3 { get; set; }
        public object WorkingHoursDayWeek3 { get; set; }
        public string WorkingHoursWorkHours3 { get; set; }
        public int WorkingHoursGlobalId3 { get; set; }
        public int WorkingHoursisDeleted4 { get; set; }
        public object WorkingHoursDayWeek4 { get; set; }
        public string WorkingHoursWorkHours4 { get; set; }
        public int WorkingHoursGlobalId4 { get; set; }
        public int WorkingHoursisDeleted5 { get; set; }
        public object WorkingHoursDayWeek5 { get; set; }
        public string WorkingHoursWorkHours5 { get; set; }
        public int WorkingHoursGlobalId5 { get; set; }
        public int WorkingHoursisDeleted6 { get; set; }
        public object WorkingHoursDayWeek6 { get; set; }
        public string WorkingHoursWorkHours6 { get; set; }
        public int WorkingHoursGlobalId6 { get; set; }
        public int PublicPhoneisDeleted1 { get; set; }
        public string PublicPhonePublicPhone1 { get; set; }
        public int PublicPhoneGlobalId1 { get; set; }
        public int PublicPhoneisDeleted2 { get; set; }
        public string PublicPhonePublicPhone2 { get; set; }
        public int PublicPhoneGlobalId2 { get; set; }
        public int FaxisDeleted1 { get; set; }
        public string FaxFax1 { get; set; }
        public int FaxGlobalId1 { get; set; }
        public int ObjectAddressisDeleted1 { get; set; }
        public object ObjectAddressAdmArea1 { get; set; }
        public object ObjectAddressDistrict1 { get; set; }
        public string ObjectAddressPostalCode1 { get; set; }
        public string ObjectAddressAddress1 { get; set; }
        public Objectaddressavailability1[] ObjectAddressAvailability1 { get; set; }
        public string ObjectAddressExtrainfo1 { get; set; }
        public int ObjectAddressGlobalId1 { get; set; }
    }

    public class Orginfochiefphone0
    {
        public int IsDeleted { get; set; }
        public string GlobalId { get; set; }
        public string ChiefPhone { get; set; }
    }

    public class Objectaddressavailability0
    {
        public int IsDeleted { get; set; }
        public string GlobalId { get; set; }
        public object AvailableK { get; set; }
        public object AvailableO { get; set; }
        public object AvailableZ { get; set; }
        public object AvailableS { get; set; }
        public AvailableElement[] AvailableElement { get; set; }
    }

    public class AvailableElement
    {
        public int IsDeleted { get; set; }
        public string GlobalId { get; set; }
        public object GroupMgn { get; set; }
        public object AreaMgn { get; set; }
        public object ElementMgn { get; set; }
        public object AvailableDegree { get; set; }
        public object AvailableIndex { get; set; }
    }

    public class Objectaddressavailability1
    {
        public int IsDeleted { get; set; }
        public string GlobalId { get; set; }
        public object AvailableK { get; set; }
        public object AvailableO { get; set; }
        public object AvailableZ { get; set; }
        public object AvailableS { get; set; }
        public object[] AvailableElement { get; set; }
    }

}