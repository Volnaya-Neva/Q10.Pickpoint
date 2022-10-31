namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json3245 : JsonType1
{
    public class Properties
    {
        public string StationaryObjectName { get; set; }
        public string ObjectType { get; set; }
        public Parkname ParkName { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public float FacilityArea { get; set; }
        public string GlobalId { get; set; }
    }

    public class Parkname
    {
        public string GlobalId { get; set; }
        public string Value { get; set; }
    }

}