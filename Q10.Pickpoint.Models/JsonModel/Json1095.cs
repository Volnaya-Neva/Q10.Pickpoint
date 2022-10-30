namespace Q10.Pickpoint.Models.JsonModel;

public class Json1095
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
        public string PostalCode { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public object AddressExtraInfo { get; set; }
        public string ChiefPhone { get; set; }
        public string DeliveryDepartmentPhone { get; set; }
        public string TelegraphPhone { get; set; }
        public string WorkingHours { get; set; }
        public string WorkingHoursExtraInfo { get; set; }
        public string ClassOps { get; set; }
        public string TypeOps { get; set; }
        public string Mmp { get; set; }
        public string CloseFlag { get; set; }
        public object CloseExtraInfo { get; set; }
        public string Unom { get; set; }
        public string XWgs84 { get; set; }
        public string YWgs84 { get; set; }
        public string GlobalId { get; set; }
    }

}