namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json2663 : JsonType1
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
        public string DepartamentalAffiliation { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string Location { get; set; }
        public float DogParkArea { get; set; }
        public string Lighting { get; set; }
        public string Fencing { get; set; }
        public long GlobalId { get; set; }
        public int Photoisdeleted0 { get; set; }
        public object PhotoPhoto0 { get; set; }
        public int PhotoGlobalId0 { get; set; }
        public int Photoisdeleted1 { get; set; }
        public object PhotoPhoto1 { get; set; }
        public int PhotoGlobalId1 { get; set; }
        public int WorkingHoursisdeleted0 { get; set; }
        public object WorkingHoursDayOfWeek0 { get; set; }
        public string WorkingHoursHours0 { get; set; }
        public int WorkingHoursGlobalId0 { get; set; }
        public int WorkingHoursisdeleted1 { get; set; }
        public object WorkingHoursDayOfWeek1 { get; set; }
        public string WorkingHoursHours1 { get; set; }
        public int WorkingHoursGlobalId1 { get; set; }
        public int WorkingHoursisdeleted2 { get; set; }
        public object WorkingHoursDayOfWeek2 { get; set; }
        public string WorkingHoursHours2 { get; set; }
        public int WorkingHoursGlobalId2 { get; set; }
        public int WorkingHoursisdeleted3 { get; set; }
        public object WorkingHoursDayOfWeek3 { get; set; }
        public string WorkingHoursHours3 { get; set; }
        public int WorkingHoursGlobalId3 { get; set; }
        public int WorkingHoursisdeleted4 { get; set; }
        public object WorkingHoursDayOfWeek4 { get; set; }
        public string WorkingHoursHours4 { get; set; }
        public int WorkingHoursGlobalId4 { get; set; }
        public int WorkingHoursisdeleted5 { get; set; }
        public object WorkingHoursDayOfWeek5 { get; set; }
        public string WorkingHoursHours5 { get; set; }
        public int WorkingHoursGlobalId5 { get; set; }
        public int WorkingHoursisdeleted6 { get; set; }
        public object WorkingHoursDayOfWeek6 { get; set; }
        public string WorkingHoursHours6 { get; set; }
        public int WorkingHoursGlobalId6 { get; set; }
        public string Elements { get; set; }
        public int Photoisdeleted2 { get; set; }
        public object PhotoPhoto2 { get; set; }
        public int PhotoGlobalId2 { get; set; }
        public int Photoisdeleted3 { get; set; }
        public object PhotoPhoto3 { get; set; }
        public int PhotoGlobalId3 { get; set; }
        public int Photoisdeleted4 { get; set; }
        public object PhotoPhoto4 { get; set; }
        public int PhotoGlobalId4 { get; set; }
    }

}