namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json2250 : JsonType1
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
        public string EventDate { get; set; }
        public string EventName { get; set; }
        public string Location { get; set; }
        public string Address { get; set; }
        public string Time { get; set; }
        public string PaymentInfo { get; set; }
        public int GlobalId { get; set; }
    }

}