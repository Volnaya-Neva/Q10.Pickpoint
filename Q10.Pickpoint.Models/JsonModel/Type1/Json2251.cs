namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json2251 : JsonType1
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
        public string EventName { get; set; }
        public string Location { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string Time { get; set; }
        public string ShortDescription { get; set; }
        public string LinkToTheEvent { get; set; }
        public string FormOfParticipation { get; set; }
        public long GlobalId { get; set; }
    }

}