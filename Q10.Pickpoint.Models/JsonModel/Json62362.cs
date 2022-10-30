namespace Q10.Pickpoint.Models.JsonModel;

public class Json62362
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
        public string LocationDescriptionEn { get; set; }
        public object AdmAreaEn { get; set; }
        public object DistrictEn { get; set; }
        public string ClarificationOfLocationEn { get; set; }
        public string ClarificationOfWorkingHoursEn { get; set; }
        public string OpenDateEn { get; set; }
        public string CloseDateEn { get; set; }
        public string ExtraInfoEn { get; set; }
        public int GlobalId { get; set; }
    }

}