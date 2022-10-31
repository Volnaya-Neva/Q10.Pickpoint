namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json2198 : JsonType1
{
    public class Properties
    {
        public int Iden { get; set; }
        public string Nameen { get; set; }
        public TunnelEn Tunnelen { get; set; }
        public object AdmAreaen { get; set; }
        public object Districten { get; set; }
        public string LongitudeWgs84En { get; set; }
        public string LatitudeWgs84En { get; set; }
        public string GlobalId { get; set; }
    }

    public class TunnelEn
    {
        public string GlobalId { get; set; }
        public string Value { get; set; }
    }

}