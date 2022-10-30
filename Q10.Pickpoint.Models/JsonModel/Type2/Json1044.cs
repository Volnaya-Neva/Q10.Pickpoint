namespace Q10.Pickpoint.Models.JsonModel.Type2;

public class Json1044 : JsonType2
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
        public string CommonName { get; set; }
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public string ChiefName { get; set; }
        public string ChiefPosition { get; set; }
        public string ClarificationWorkingHours { get; set; }
        public string WebSite { get; set; }
        public int GlobalId { get; set; }
        public int OrgInfoisDeleted0 { get; set; }
        public string OrgInfoFullName0 { get; set; }
        public Orginfochiefphone0[] OrgInfoChiefPhone0 { get; set; }
        public string OrgInfoInn0 { get; set; }
        public string OrgInfoKpp0 { get; set; }
        public string OrgInfoOgrn0 { get; set; }
        public string OrgInfoLegalAddress0 { get; set; }
        public string OrgInfoChiefName0 { get; set; }
        public string OrgInfoChiefPosition0 { get; set; }
        public int OrgInfoGlobalId0 { get; set; }
        public int ObjectAddressisDeleted0 { get; set; }
        public object ObjectAddressAdmArea0 { get; set; }
        public object ObjectAddressDistrict0 { get; set; }
        public string ObjectAddressPostalCode0 { get; set; }
        public string ObjectAddressAddress0 { get; set; }
        public object ObjectAddressSocialServices0 { get; set; }
        public Objectaddressavailability0[] ObjectAddressAvailability0 { get; set; }
        public int ObjectAddressGlobalId0 { get; set; }
        public int PublicPhoneisDeleted0 { get; set; }
        public string PublicPhonePublicPhone0 { get; set; }
        public int PublicPhoneGlobalId0 { get; set; }
        public int PublicPhoneisDeleted1 { get; set; }
        public string PublicPhonePublicPhone1 { get; set; }
        public int PublicPhoneGlobalId1 { get; set; }
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

}