namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json1099 : JsonType1
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
        public string Name { get; set; }
        public string AttendedDistrict { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string WorkingHours { get; set; }
        public string ClarificationOfWorkingHours { get; set; }
        public string PublicPhone { get; set; }
        public string WebSite { get; set; }
        public string Service { get; set; }
        public string XWgs { get; set; }
        public string YWgs { get; set; }
        public string GlobalId { get; set; }
    }

}