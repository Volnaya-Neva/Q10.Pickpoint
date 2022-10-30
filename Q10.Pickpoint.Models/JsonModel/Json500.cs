namespace Q10.Pickpoint.Models.JsonModel;

public class Json500
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
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string ClarificationOfWorkingHours { get; set; }
        public int GlobalId { get; set; }
        public int Phoneisdeleted0 { get; set; }
        public int PhoneGlobalId0 { get; set; }
        public string PhonePhone0 { get; set; }
        public int Emailisdeleted0 { get; set; }
        public int EmailGlobalId0 { get; set; }
        public string EmailEmail0 { get; set; }
        public int WorkingHoursisdeleted0 { get; set; }
        public int WorkingHoursGlobalId0 { get; set; }
        public object WorkingHoursDayOfWeek0 { get; set; }
        public string WorkingHoursHours0 { get; set; }
        public int WorkingHoursisdeleted1 { get; set; }
        public int WorkingHoursGlobalId1 { get; set; }
        public object WorkingHoursDayOfWeek1 { get; set; }
        public string WorkingHoursHours1 { get; set; }
        public int WorkingHoursisdeleted2 { get; set; }
        public int WorkingHoursGlobalId2 { get; set; }
        public object WorkingHoursDayOfWeek2 { get; set; }
        public string WorkingHoursHours2 { get; set; }
        public int WorkingHoursisdeleted3 { get; set; }
        public int WorkingHoursGlobalId3 { get; set; }
        public object WorkingHoursDayOfWeek3 { get; set; }
        public string WorkingHoursHours3 { get; set; }
        public int WorkingHoursisdeleted4 { get; set; }
        public int WorkingHoursGlobalId4 { get; set; }
        public object WorkingHoursDayOfWeek4 { get; set; }
        public string WorkingHoursHours4 { get; set; }
        public int WorkingHoursisdeleted5 { get; set; }
        public int WorkingHoursGlobalId5 { get; set; }
        public object WorkingHoursDayOfWeek5 { get; set; }
        public string WorkingHoursHours5 { get; set; }
        public int WorkingHoursisdeleted6 { get; set; }
        public int WorkingHoursGlobalId6 { get; set; }
        public object WorkingHoursDayOfWeek6 { get; set; }
        public string WorkingHoursHours6 { get; set; }
        public int Phoneisdeleted1 { get; set; }
        public int PhoneGlobalId1 { get; set; }
        public string PhonePhone1 { get; set; }
        public int Emailisdeleted1 { get; set; }
        public int EmailGlobalId1 { get; set; }
        public string EmailEmail1 { get; set; }
        public int Phoneisdeleted2 { get; set; }
        public int PhoneGlobalId2 { get; set; }
        public string PhonePhone2 { get; set; }
        public int Phoneisdeleted3 { get; set; }
        public int PhoneGlobalId3 { get; set; }
        public string PhonePhone3 { get; set; }
    }

}