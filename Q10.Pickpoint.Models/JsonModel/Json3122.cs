namespace Q10.Pickpoint.Models.JsonModel;

public class Json3122
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
        public int Iden { get; set; }
        public string Nameen { get; set; }
        public string Positionen { get; set; }
        public string AdmAreaen { get; set; }
        public string Districten { get; set; }
        public string Addressen { get; set; }
        public string Locationen { get; set; }
        public string ExtraInfoen { get; set; }
        public int GlobalId { get; set; }
        public int WorkingHoursenisdeleted0 { get; set; }
        public string WorkingHoursenDayOfWeeken0 { get; set; }
        public string WorkingHoursenHoursen0 { get; set; }
        public int WorkingHoursenGlobalId0 { get; set; }
        public int WorkingHoursenisdeleted1 { get; set; }
        public string WorkingHoursenDayOfWeeken1 { get; set; }
        public string WorkingHoursenHoursen1 { get; set; }
        public int WorkingHoursenGlobalId1 { get; set; }
        public int WorkingHoursenisdeleted2 { get; set; }
        public string WorkingHoursenDayOfWeeken2 { get; set; }
        public string WorkingHoursenHoursen2 { get; set; }
        public int WorkingHoursenGlobalId2 { get; set; }
        public int WorkingHoursenisdeleted3 { get; set; }
        public string WorkingHoursenDayOfWeeken3 { get; set; }
        public string WorkingHoursenHoursen3 { get; set; }
        public int WorkingHoursenGlobalId3 { get; set; }
        public int WorkingHoursenisdeleted4 { get; set; }
        public string WorkingHoursenDayOfWeeken4 { get; set; }
        public string WorkingHoursenHoursen4 { get; set; }
        public int WorkingHoursenGlobalId4 { get; set; }
        public int WorkingHoursenisdeleted5 { get; set; }
        public string WorkingHoursenDayOfWeeken5 { get; set; }
        public string WorkingHoursenHoursen5 { get; set; }
        public int WorkingHoursenGlobalId5 { get; set; }
        public int WorkingHoursenisdeleted6 { get; set; }
        public string WorkingHoursenDayOfWeeken6 { get; set; }
        public string WorkingHoursenHoursen6 { get; set; }
        public int WorkingHoursenGlobalId6 { get; set; }
        public int Phoneenisdeleted0 { get; set; }
        public string PhoneenPublicPhoneen0 { get; set; }
        public int PhoneenGlobalId0 { get; set; }
    }

}