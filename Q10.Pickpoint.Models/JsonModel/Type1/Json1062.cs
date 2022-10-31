namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json1062 : JsonType1
{
    public class Properties
    {
        public string Name { get; set; }
        public string Owner { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public int DailyOutput { get; set; }
        public string LongitudeWgs84 { get; set; }
        public string LatitudeWgs84 { get; set; }
        public string GlobalId { get; set; }
    }
}