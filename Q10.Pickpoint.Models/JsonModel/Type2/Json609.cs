namespace Q10.Pickpoint.Models.JsonModel.Type2;

public class Json609 : JsonType2
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
        public int OrgInfoisdeleted0 { get; set; }
        public int OrgInfoglobalobjectid0 { get; set; }
        public int OrgInfoGlobalId0 { get; set; }
        public string OrgInfosystemobjectid0 { get; set; }
        public Orginfochiefphone0[] OrgInfoChiefPhone0 { get; set; }
        public string OrgInfoInn0 { get; set; }
        public string OrgInfoKpp0 { get; set; }
        public string OrgInfoOgrn0 { get; set; }
        public string OrgInfoLegalAddress0 { get; set; }
        public string OrgInfoFullName0 { get; set; }
        public string OrgInfoChiefName0 { get; set; }
        public string OrgInfoChiefPosition0 { get; set; }
        public int ObjectAddressisdeleted0 { get; set; }
        public int ObjectAddressglobalobjectid0 { get; set; }
        public int ObjectAddressGlobalId0 { get; set; }
        public string ObjectAddresssystemobjectid0 { get; set; }
        public object ObjectAddressAdmArea0 { get; set; }
        public object ObjectAddressDistrict0 { get; set; }
        public string ObjectAddressPostalCode0 { get; set; }
        public string ObjectAddressAddress0 { get; set; }
        public object ObjectAddressSocialServices0 { get; set; }
        public Objectaddressavailability0[] ObjectAddressAvailability0 { get; set; }
        public int ObjectAddressisdeleted1 { get; set; }
        public int ObjectAddressglobalobjectid1 { get; set; }
        public int ObjectAddressGlobalId1 { get; set; }
        public string ObjectAddresssystemobjectid1 { get; set; }
        public object ObjectAddressAdmArea1 { get; set; }
        public object ObjectAddressDistrict1 { get; set; }
        public string ObjectAddressPostalCode1 { get; set; }
        public string ObjectAddressAddress1 { get; set; }
        public object ObjectAddressSocialServices1 { get; set; }
        public Objectaddressavailability1[] ObjectAddressAvailability1 { get; set; }
        public int PublicPhoneisdeleted0 { get; set; }
        public int PublicPhoneglobalobjectid0 { get; set; }
        public int PublicPhoneGlobalId0 { get; set; }
        public string PublicPhonesystemobjectid0 { get; set; }
        public string PublicPhonePublicPhone0 { get; set; }
        public int WorkingHoursisdeleted0 { get; set; }
        public int WorkingHoursglobalobjectid0 { get; set; }
        public int WorkingHoursGlobalId0 { get; set; }
        public string WorkingHourssystemobjectid0 { get; set; }
        public object WorkingHoursDayWeek0 { get; set; }
        public string WorkingHoursWorkHours0 { get; set; }
        public int WorkingHoursisdeleted1 { get; set; }
        public int WorkingHoursglobalobjectid1 { get; set; }
        public int WorkingHoursGlobalId1 { get; set; }
        public string WorkingHourssystemobjectid1 { get; set; }
        public object WorkingHoursDayWeek1 { get; set; }
        public string WorkingHoursWorkHours1 { get; set; }
        public int WorkingHoursisdeleted2 { get; set; }
        public int WorkingHoursglobalobjectid2 { get; set; }
        public int WorkingHoursGlobalId2 { get; set; }
        public string WorkingHourssystemobjectid2 { get; set; }
        public object WorkingHoursDayWeek2 { get; set; }
        public string WorkingHoursWorkHours2 { get; set; }
        public int WorkingHoursisdeleted3 { get; set; }
        public int WorkingHoursglobalobjectid3 { get; set; }
        public int WorkingHoursGlobalId3 { get; set; }
        public string WorkingHourssystemobjectid3 { get; set; }
        public object WorkingHoursDayWeek3 { get; set; }
        public string WorkingHoursWorkHours3 { get; set; }
        public int WorkingHoursisdeleted4 { get; set; }
        public int WorkingHoursglobalobjectid4 { get; set; }
        public int WorkingHoursGlobalId4 { get; set; }
        public string WorkingHourssystemobjectid4 { get; set; }
        public object WorkingHoursDayWeek4 { get; set; }
        public string WorkingHoursWorkHours4 { get; set; }
        public int WorkingHoursisdeleted5 { get; set; }
        public int WorkingHoursglobalobjectid5 { get; set; }
        public int WorkingHoursGlobalId5 { get; set; }
        public string WorkingHourssystemobjectid5 { get; set; }
        public object WorkingHoursDayWeek5 { get; set; }
        public string WorkingHoursWorkHours5 { get; set; }
        public int WorkingHoursisdeleted6 { get; set; }
        public int WorkingHoursglobalobjectid6 { get; set; }
        public int WorkingHoursGlobalId6 { get; set; }
        public string WorkingHourssystemobjectid6 { get; set; }
        public object WorkingHoursDayWeek6 { get; set; }
        public string WorkingHoursWorkHours6 { get; set; }
        public int PublicPhoneisdeleted1 { get; set; }
        public int PublicPhoneglobalobjectid1 { get; set; }
        public int PublicPhoneGlobalId1 { get; set; }
        public string PublicPhonesystemobjectid1 { get; set; }
        public string PublicPhonePublicPhone1 { get; set; }
    }

    public class Orginfochiefphone0
    {
        public int Isdeleted { get; set; }
        public int Globalobjectid { get; set; }
        public int GlobalId { get; set; }
        public string Systemobjectid { get; set; }
        public string ChiefPhone { get; set; }
    }

    public class Objectaddressavailability0
    {
        public int Isdeleted { get; set; }
        public int Globalobjectid { get; set; }
        public int GlobalId { get; set; }
        public string Systemobjectid { get; set; }
        public object Availablek { get; set; }
        public object Availableo { get; set; }
        public object Availablez { get; set; }
        public object Availables { get; set; }
        public AvailableElement[] Availableelement { get; set; }
    }

    public class AvailableElement
    {
        public int Isdeleted { get; set; }
        public int Globalobjectid { get; set; }
        public int GlobalId { get; set; }
        public string Systemobjectid { get; set; }
        public object Groupmgn { get; set; }
        public object Areamgn { get; set; }
        public object Elementmgn { get; set; }
        public object Availabledegree { get; set; }
        public object Availableindex { get; set; }
    }

    public class Objectaddressavailability1
    {
        public int Isdeleted { get; set; }
        public int Globalobjectid { get; set; }
        public int GlobalId { get; set; }
        public string Systemobjectid { get; set; }
        public object Availablek { get; set; }
        public object Availableo { get; set; }
        public object Availablez { get; set; }
        public object Availables { get; set; }
        public AvailableElement1[] Availableelement { get; set; }
    }

    public class AvailableElement1
    {
        public int Isdeleted { get; set; }
        public int Globalobjectid { get; set; }
        public int GlobalId { get; set; }
        public string Systemobjectid { get; set; }
        public object Groupmgn { get; set; }
        public object Areamgn { get; set; }
        public object Elementmgn { get; set; }
        public object Availabledegree { get; set; }
        public object Availableindex { get; set; }
    }

}