namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json652 : JsonType1
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
        public int GlobalId { get; set; }
        public int Phoneisdeleted0 { get; set; }
        public string PhonePhone0 { get; set; }
        public int PhoneGlobalId0 { get; set; }
    }

}