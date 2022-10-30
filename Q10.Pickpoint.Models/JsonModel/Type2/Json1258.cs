namespace Q10.Pickpoint.Models.JsonModel.Type2;

public class Json1258 : JsonType2
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
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public string ChiefName { get; set; }
        public string ChiefPosition { get; set; }
        public string ChiefGender { get; set; }
        public string PaidServiceInfo { get; set; }
        public string ClarificationWorkingHours { get; set; }
        public string BeneficialDrugPrescription { get; set; }
        public string Extrainfo { get; set; }
        public object AgeRestriction { get; set; }
        public int GlobalId { get; set; }
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
        public int ObjectAddressisDeleted1 { get; set; }
        public object ObjectAddressAdmArea1 { get; set; }
        public object ObjectAddressDistrict1 { get; set; }
        public string ObjectAddressPostalCode1 { get; set; }
        public string ObjectAddressAddress1 { get; set; }
        public Objectaddressavailability1[] ObjectAddressAvailability1 { get; set; }
        public string ObjectAddressExtrainfo1 { get; set; }
        public int ObjectAddressGlobalId1 { get; set; }
        public int ObjectAddressisDeleted2 { get; set; }
        public object ObjectAddressAdmArea2 { get; set; }
        public object ObjectAddressDistrict2 { get; set; }
        public string ObjectAddressPostalCode2 { get; set; }
        public string ObjectAddressAddress2 { get; set; }
        public Objectaddressavailability2[] ObjectAddressAvailability2 { get; set; }
        public string ObjectAddressExtrainfo2 { get; set; }
        public int ObjectAddressGlobalId2 { get; set; }
        public int ObjectAddressisDeleted3 { get; set; }
        public object ObjectAddressAdmArea3 { get; set; }
        public object ObjectAddressDistrict3 { get; set; }
        public string ObjectAddressPostalCode3 { get; set; }
        public string ObjectAddressAddress3 { get; set; }
        public Objectaddressavailability3[] ObjectAddressAvailability3 { get; set; }
        public string ObjectAddressExtrainfo3 { get; set; }
        public int ObjectAddressGlobalId3 { get; set; }
        public int ObjectAddressisDeleted4 { get; set; }
        public object ObjectAddressAdmArea4 { get; set; }
        public object ObjectAddressDistrict4 { get; set; }
        public string ObjectAddressPostalCode4 { get; set; }
        public string ObjectAddressAddress4 { get; set; }
        public Objectaddressavailability4[] ObjectAddressAvailability4 { get; set; }
        public string ObjectAddressExtrainfo4 { get; set; }
        public int ObjectAddressGlobalId4 { get; set; }
        public int ObjectAddressisDeleted5 { get; set; }
        public object ObjectAddressAdmArea5 { get; set; }
        public object ObjectAddressDistrict5 { get; set; }
        public string ObjectAddressPostalCode5 { get; set; }
        public string ObjectAddressAddress5 { get; set; }
        public Objectaddressavailability5[] ObjectAddressAvailability5 { get; set; }
        public string ObjectAddressExtrainfo5 { get; set; }
        public int ObjectAddressGlobalId5 { get; set; }
        public int ObjectAddressisDeleted6 { get; set; }
        public object ObjectAddressAdmArea6 { get; set; }
        public object ObjectAddressDistrict6 { get; set; }
        public string ObjectAddressPostalCode6 { get; set; }
        public string ObjectAddressAddress6 { get; set; }
        public Objectaddressavailability6[] ObjectAddressAvailability6 { get; set; }
        public string ObjectAddressExtrainfo6 { get; set; }
        public int ObjectAddressGlobalId6 { get; set; }
        public int ObjectAddressisDeleted7 { get; set; }
        public object ObjectAddressAdmArea7 { get; set; }
        public object ObjectAddressDistrict7 { get; set; }
        public string ObjectAddressPostalCode7 { get; set; }
        public string ObjectAddressAddress7 { get; set; }
        public Objectaddressavailability7[] ObjectAddressAvailability7 { get; set; }
        public string ObjectAddressExtrainfo7 { get; set; }
        public int ObjectAddressGlobalId7 { get; set; }
    }

    public class Orginfochiefphone0
    {
        public int IsDeleted { get; set; }
        public int GlobalId { get; set; }
        public string ChiefPhone { get; set; }
    }

    public class Objectaddressavailability0
    {
        public int IsDeleted { get; set; }
        public int GlobalId { get; set; }
        public object AvailableK { get; set; }
        public object AvailableO { get; set; }
        public object AvailableZ { get; set; }
        public object AvailableS { get; set; }
        public AvailableElement[] AvailableElement { get; set; }
    }

    public class AvailableElement
    {
        public int IsDeleted { get; set; }
        public int GlobalId { get; set; }
        public object GroupMgn { get; set; }
        public object AreaMgn { get; set; }
        public object ElementMgn { get; set; }
        public object AvailableDegree { get; set; }
        public object AvailableIndex { get; set; }
    }

    public class Objectaddressavailability1
    {
        public int IsDeleted { get; set; }
        public int GlobalId { get; set; }
        public object AvailableK { get; set; }
        public object AvailableO { get; set; }
        public object AvailableZ { get; set; }
        public object AvailableS { get; set; }
        public AvailableElement1[] AvailableElement { get; set; }
    }

    public class AvailableElement1
    {
        public int IsDeleted { get; set; }
        public int GlobalId { get; set; }
        public object GroupMgn { get; set; }
        public object AreaMgn { get; set; }
        public object ElementMgn { get; set; }
        public object AvailableDegree { get; set; }
        public object AvailableIndex { get; set; }
    }

    public class Objectaddressavailability2
    {
        public int IsDeleted { get; set; }
        public int GlobalId { get; set; }
        public object AvailableK { get; set; }
        public object AvailableO { get; set; }
        public object AvailableZ { get; set; }
        public object AvailableS { get; set; }
        public object[] AvailableElement { get; set; }
    }

    public class Objectaddressavailability3
    {
        public int IsDeleted { get; set; }
        public int GlobalId { get; set; }
        public object AvailableK { get; set; }
        public object AvailableO { get; set; }
        public object AvailableZ { get; set; }
        public object AvailableS { get; set; }
        public AvailableElement2[] AvailableElement { get; set; }
    }

    public class AvailableElement2
    {
        public int IsDeleted { get; set; }
        public int GlobalId { get; set; }
        public object GroupMgn { get; set; }
        public object AreaMgn { get; set; }
        public object ElementMgn { get; set; }
        public object AvailableDegree { get; set; }
        public object AvailableIndex { get; set; }
    }

    public class Objectaddressavailability4
    {
        public int IsDeleted { get; set; }
        public int GlobalId { get; set; }
        public object AvailableK { get; set; }
        public object AvailableO { get; set; }
        public object AvailableZ { get; set; }
        public object AvailableS { get; set; }
        public AvailableElement3[] AvailableElement { get; set; }
    }

    public class AvailableElement3
    {
        public int IsDeleted { get; set; }
        public int GlobalId { get; set; }
        public object GroupMgn { get; set; }
        public object AreaMgn { get; set; }
        public object ElementMgn { get; set; }
        public object AvailableDegree { get; set; }
        public object AvailableIndex { get; set; }
    }

    public class Objectaddressavailability5
    {
        public int IsDeleted { get; set; }
        public int GlobalId { get; set; }
        public object AvailableK { get; set; }
        public object AvailableO { get; set; }
        public object AvailableZ { get; set; }
        public object AvailableS { get; set; }
        public object[] AvailableElement { get; set; }
    }

    public class Objectaddressavailability6
    {
        public int IsDeleted { get; set; }
        public int GlobalId { get; set; }
        public object AvailableK { get; set; }
        public object AvailableO { get; set; }
        public object AvailableZ { get; set; }
        public object AvailableS { get; set; }
        public object[] AvailableElement { get; set; }
    }

    public class Objectaddressavailability7
    {
        public int IsDeleted { get; set; }
        public int GlobalId { get; set; }
        public object AvailableK { get; set; }
        public object AvailableO { get; set; }
        public object AvailableZ { get; set; }
        public object AvailableS { get; set; }
        public AvailableElement4[] AvailableElement { get; set; }
    }

    public class AvailableElement4
    {
        public int IsDeleted { get; set; }
        public int GlobalId { get; set; }
        public object GroupMgn { get; set; }
        public object AreaMgn { get; set; }
        public object ElementMgn { get; set; }
        public object AvailableDegree { get; set; }
        public object AvailableIndex { get; set; }
    }

}