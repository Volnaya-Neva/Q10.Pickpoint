namespace Q10.Pickpoint.Models.JsonModel;

public class Json61841
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
        public string Address { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string ClarificationOfLocation { get; set; }
        public string ClarificationOfWorkingHours { get; set; }
        public string OpenDate { get; set; }
        public string CloseDate { get; set; }
        public string ExtraInfo { get; set; }
        public int GlobalId { get; set; }
        public int PublicPhoneisDeleted0 { get; set; }
        public int PublicPhoneGlobalId0 { get; set; }
        public string PublicPhonePublicPhone0 { get; set; }
        public int WorkingHoursisDeleted0 { get; set; }
        public int WorkingHoursGlobalId0 { get; set; }
        public object WorkingHoursDayOfWeek0 { get; set; }
        public string WorkingHoursHours0 { get; set; }
        public int WorkingHoursisDeleted1 { get; set; }
        public int WorkingHoursGlobalId1 { get; set; }
        public object WorkingHoursDayOfWeek1 { get; set; }
        public string WorkingHoursHours1 { get; set; }
        public int WorkingHoursisDeleted2 { get; set; }
        public int WorkingHoursGlobalId2 { get; set; }
        public object WorkingHoursDayOfWeek2 { get; set; }
        public string WorkingHoursHours2 { get; set; }
        public int WorkingHoursisDeleted3 { get; set; }
        public int WorkingHoursGlobalId3 { get; set; }
        public object WorkingHoursDayOfWeek3 { get; set; }
        public string WorkingHoursHours3 { get; set; }
        public int WorkingHoursisDeleted4 { get; set; }
        public int WorkingHoursGlobalId4 { get; set; }
        public object WorkingHoursDayOfWeek4 { get; set; }
        public string WorkingHoursHours4 { get; set; }
        public int WorkingHoursisDeleted5 { get; set; }
        public int WorkingHoursGlobalId5 { get; set; }
        public object WorkingHoursDayOfWeek5 { get; set; }
        public string WorkingHoursHours5 { get; set; }
        public int WorkingHoursisDeleted6 { get; set; }
        public int WorkingHoursGlobalId6 { get; set; }
        public object WorkingHoursDayOfWeek6 { get; set; }
        public string WorkingHoursHours6 { get; set; }
        public int PublicPhoneisDeleted1 { get; set; }
        public int PublicPhoneGlobalId1 { get; set; }
        public string PublicPhonePublicPhone1 { get; set; }
        public int PublicPhoneisDeleted2 { get; set; }
        public int PublicPhoneGlobalId2 { get; set; }
        public string PublicPhonePublicPhone2 { get; set; }
    }

}