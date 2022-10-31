namespace Q10.Pickpoint.Models.JsonModel.Type2;

public class Json508 : JsonType2
{
    public class Properties
    {
        public string GlobalId { get; set; }
        public string CommonName { get; set; }
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public string ChiefName { get; set; }
        public object ClarificationWorkingHours { get; set; }
        public object WebSite { get; set; }
        public string ChiefPosition { get; set; }
        public string OrgInfoFullName0 { get; set; }
        public string OrgInfoInn0 { get; set; }
        public string OrgInfoKpp0 { get; set; }
        public string OrgInfoOgrn0 { get; set; }
        public string OrgInfoLegalAddress0 { get; set; }
        public string OrgInfoChiefName0 { get; set; }
        public string OrgInfoChiefPosition0 { get; set; }
        public Orginfochiefphone0[] OrgInfoChiefPhone0 { get; set; }
        public string ObjectAddressAdmArea0 { get; set; }
        public string ObjectAddressDistrict0 { get; set; }
        public string ObjectAddressPostalCode0 { get; set; }
        public string ObjectAddressAddress0 { get; set; }
        public Objectaddressavailability0[] ObjectAddressAvailability0 { get; set; }
        public string PublicPhonePublicPhone0 { get; set; }
        public string WorkingHoursDayWeek0 { get; set; }
        public string WorkingHoursWorkHours0 { get; set; }
        public string WorkingHoursDayWeek1 { get; set; }
        public string WorkingHoursWorkHours1 { get; set; }
        public string WorkingHoursDayWeek2 { get; set; }
        public string WorkingHoursWorkHours2 { get; set; }
        public string WorkingHoursDayWeek3 { get; set; }
        public string WorkingHoursWorkHours3 { get; set; }
        public string WorkingHoursDayWeek4 { get; set; }
        public string WorkingHoursWorkHours4 { get; set; }
        public string WorkingHoursDayWeek5 { get; set; }
        public string WorkingHoursWorkHours5 { get; set; }
        public string WorkingHoursDayWeek6 { get; set; }
        public string WorkingHoursWorkHours6 { get; set; }
        public string PublicPhonePublicPhone1 { get; set; }
        public string PublicPhonePublicPhone2 { get; set; }
    }

    public class Orginfochiefphone0
    {
        public string ChiefPhone { get; set; }
    }

    public class Objectaddressavailability0
    {
        public string Availablek { get; set; }
        public string Availableo { get; set; }
        public string Availablez { get; set; }
        public string Availables { get; set; }
        public AvailableElement[] Availableelement { get; set; }
    }

    public class AvailableElement
    {
        public string Groupmgn { get; set; }
        public string Areamgn { get; set; }
        public string Elementmgn { get; set; }
        public string Availabledegree { get; set; }
        public string Availableindex { get; set; }
    }


}