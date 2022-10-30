namespace Q10.Pickpoint.Models.JsonModel;

public class Json620
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
        public int Id { get; set; }
        public string Address { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string StatusFairs { get; set; }
        public string PeriodOfPlacement { get; set; }
        public string GoodsCategory { get; set; }
        public string SituationalPlan { get; set; }
        public int AmountOfPlaces { get; set; }
        public string LongitudeWgs84 { get; set; }
        public string LatitudeWgs84 { get; set; }
        public string Unom { get; set; }
        public string EntryState { get; set; }
        public string Photo { get; set; }
        public long GlobalId { get; set; }
    }

}