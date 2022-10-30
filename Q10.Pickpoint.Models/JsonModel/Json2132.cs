namespace Q10.Pickpoint.Models.JsonModel;

public class Json2132
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
        public int IdEn { get; set; }
        public string FullNameEn { get; set; }
        public string ShortNameEn { get; set; }
        public string InnEn { get; set; }
        public string KppEn { get; set; }
        public string OgrnEn { get; set; }
        public string AdmAreaEn { get; set; }
        public string DistrictEn { get; set; }
        public string AddressEn { get; set; }
        public string ClarificationOfWorkingHoursEn { get; set; }
        public int GlobalId { get; set; }
        public int PhoneEnisDeleted0 { get; set; }
        public string PhoneEnPhoneEn0 { get; set; }
        public int PhoneEnGlobalId0 { get; set; }
        public int PhoneEnisDeleted1 { get; set; }
        public string PhoneEnPhoneEn1 { get; set; }
        public int PhoneEnGlobalId1 { get; set; }
        public int EmailEnisDeleted0 { get; set; }
        public string EmailEnEmailEn0 { get; set; }
        public int EmailEnGlobalId0 { get; set; }
        public int WorkingHoursEnisDeleted0 { get; set; }
        public string WorkingHoursEnDayOfWeekEn0 { get; set; }
        public string WorkingHoursEnHoursEn0 { get; set; }
        public int WorkingHoursEnGlobalId0 { get; set; }
        public int WorkingHoursEnisDeleted1 { get; set; }
        public string WorkingHoursEnDayOfWeekEn1 { get; set; }
        public string WorkingHoursEnHoursEn1 { get; set; }
        public int WorkingHoursEnGlobalId1 { get; set; }
        public int WorkingHoursEnisDeleted2 { get; set; }
        public string WorkingHoursEnDayOfWeekEn2 { get; set; }
        public string WorkingHoursEnHoursEn2 { get; set; }
        public int WorkingHoursEnGlobalId2 { get; set; }
        public int WorkingHoursEnisDeleted3 { get; set; }
        public string WorkingHoursEnDayOfWeekEn3 { get; set; }
        public string WorkingHoursEnHoursEn3 { get; set; }
        public int WorkingHoursEnGlobalId3 { get; set; }
        public int WorkingHoursEnisDeleted4 { get; set; }
        public string WorkingHoursEnDayOfWeekEn4 { get; set; }
        public string WorkingHoursEnHoursEn4 { get; set; }
        public int WorkingHoursEnGlobalId4 { get; set; }
        public int WorkingHoursEnisDeleted5 { get; set; }
        public string WorkingHoursEnDayOfWeekEn5 { get; set; }
        public string WorkingHoursEnHoursEn5 { get; set; }
        public int WorkingHoursEnGlobalId5 { get; set; }
        public int WorkingHoursEnisDeleted6 { get; set; }
        public string WorkingHoursEnDayOfWeekEn6 { get; set; }
        public string WorkingHoursEnHoursEn6 { get; set; }
        public int WorkingHoursEnGlobalId6 { get; set; }
        public int EmailEnisDeleted1 { get; set; }
        public string EmailEnEmailEn1 { get; set; }
        public int EmailEnGlobalId1 { get; set; }
    }

}