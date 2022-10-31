namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json1344 : JsonType1
{
    public class Properties
    {
        public string Name { get; set; }
        public Tunnel Tunnel { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string LongitudeWgs84 { get; set; }
        public string LatitudeWgs84 { get; set; }
        public string GlobalId { get; set; }
    }

    public class Tunnel
    {
        public string GlobalId { get; set; }
        public string Value { get; set; }
    }

}