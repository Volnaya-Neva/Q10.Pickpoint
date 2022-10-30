namespace Q10.Pickpoint.Models.JsonModel;

public class Json62841
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
        public string NameOfStation { get; set; }
        public string Line { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string ClarificationOfWorkingHours { get; set; }
        public int BpaAmount { get; set; }
        public int GlobalId { get; set; }
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
        public int TrainScheduleisDeleted0 { get; set; }
        public int TrainScheduleGlobalId0 { get; set; }
        public object TrainScheduleNameOfStation0 { get; set; }
        public Trainscheduledeparturetime0[] TrainScheduleDepartureTime0 { get; set; }
        public int TrainScheduleisDeleted1 { get; set; }
        public int TrainScheduleGlobalId1 { get; set; }
        public object TrainScheduleNameOfStation1 { get; set; }
        public Trainscheduledeparturetime1[] TrainScheduleDepartureTime1 { get; set; }
    }

    public class Trainscheduledeparturetime0
    {
        public int IsDeleted { get; set; }
        public int GlobalId { get; set; }
        public string DepartureTime { get; set; }
    }

    public class Trainscheduledeparturetime1
    {
        public int IsDeleted { get; set; }
        public int GlobalId { get; set; }
        public string DepartureTime { get; set; }
    }

}