namespace Q10.Pickpoint.Models.JsonModel;

public class Json2447
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
        public string StationName { get; set; }
        public string StationPurpose { get; set; }
        public string SurveillanceZoneCharacteristics { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string Location { get; set; }
        public int StartUpYear { get; set; }
        public string IsWorking { get; set; }
        public int GlobalId { get; set; }
    }

}