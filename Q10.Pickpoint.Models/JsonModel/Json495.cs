namespace Q10.Pickpoint.Models.JsonModel;

public class Json495
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
        public string ChiefOrg { get; set; }
        public string ChiefName { get; set; }
        public string ChiefPosition { get; set; }
        public string ClarificationOfWorkingHours { get; set; }
        public string WebSite { get; set; }
        public int NumberOfHalls { get; set; }
        public int TotalSeatsAmount { get; set; }
        public int GlobalId { get; set; }
        public int OrgInfoisdeleted0 { get; set; }
        public Orginfochiefphone0[] OrgInfoChiefPhone0 { get; set; }
        public string OrgInfoFullName0 { get; set; }
        public string OrgInfoInn0 { get; set; }
        public string OrgInfoKpp0 { get; set; }
        public string OrgInfoOgrn0 { get; set; }
        public string OrgInfoLegalAddress0 { get; set; }
        public string OrgInfoChiefName0 { get; set; }
        public object OrgInfoChiefPosition0 { get; set; }
        public int OrgInfoGlobalId0 { get; set; }
        public int ObjectAddressisdeleted0 { get; set; }
        public object ObjectAddressAdmArea0 { get; set; }
        public object ObjectAddressDistrict0 { get; set; }
        public string ObjectAddressPostalCode0 { get; set; }
        public string ObjectAddressAddress0 { get; set; }
        public Objectaddressavailability0[] ObjectAddressAvailability0 { get; set; }
        public int ObjectAddressGlobalId0 { get; set; }
        public int PublicPhoneisdeleted0 { get; set; }
        public string PublicPhonePublicPhone0 { get; set; }
        public int PublicPhoneGlobalId0 { get; set; }
        public int PublicPhoneisdeleted1 { get; set; }
        public string PublicPhonePublicPhone1 { get; set; }
        public int PublicPhoneGlobalId1 { get; set; }
        public int Emailisdeleted0 { get; set; }
        public string EmailEmail0 { get; set; }
        public int EmailGlobalId0 { get; set; }
        public int WorkingHoursisdeleted0 { get; set; }
        public object WorkingHoursDayWeek0 { get; set; }
        public string WorkingHoursWorkHours0 { get; set; }
        public int WorkingHoursGlobalId0 { get; set; }
        public int WorkingHoursisdeleted1 { get; set; }
        public object WorkingHoursDayWeek1 { get; set; }
        public string WorkingHoursWorkHours1 { get; set; }
        public int WorkingHoursGlobalId1 { get; set; }
        public int WorkingHoursisdeleted2 { get; set; }
        public object WorkingHoursDayWeek2 { get; set; }
        public string WorkingHoursWorkHours2 { get; set; }
        public int WorkingHoursGlobalId2 { get; set; }
        public int WorkingHoursisdeleted3 { get; set; }
        public object WorkingHoursDayWeek3 { get; set; }
        public string WorkingHoursWorkHours3 { get; set; }
        public int WorkingHoursGlobalId3 { get; set; }
        public int WorkingHoursisdeleted4 { get; set; }
        public object WorkingHoursDayWeek4 { get; set; }
        public string WorkingHoursWorkHours4 { get; set; }
        public int WorkingHoursGlobalId4 { get; set; }
        public int WorkingHoursisdeleted5 { get; set; }
        public object WorkingHoursDayWeek5 { get; set; }
        public string WorkingHoursWorkHours5 { get; set; }
        public int WorkingHoursGlobalId5 { get; set; }
        public int WorkingHoursisdeleted6 { get; set; }
        public object WorkingHoursDayWeek6 { get; set; }
        public string WorkingHoursWorkHours6 { get; set; }
        public int WorkingHoursGlobalId6 { get; set; }
        public int Faxisdeleted0 { get; set; }
        public string FaxFax0 { get; set; }
        public int FaxGlobalId0 { get; set; }
    }

    public class Orginfochiefphone0
    {
        public int Isdeleted { get; set; }
        public int GlobalId { get; set; }
        public string ChiefPhone { get; set; }
    }

    public class Objectaddressavailability0
    {
        public int Isdeleted { get; set; }
        public int GlobalId { get; set; }
        public object Availablek { get; set; }
        public object Availableo { get; set; }
        public object Availablez { get; set; }
        public object Availables { get; set; }
        public AvailableElement[] Availableelement { get; set; }
    }

    public class AvailableElement
    {
        public int Isdeleted { get; set; }
        public int GlobalId { get; set; }
        public object Groupmgn { get; set; }
        public object Areamgn { get; set; }
        public object Elementmgn { get; set; }
        public object Availabledegree { get; set; }
        public object Availableindex { get; set; }
    }

}