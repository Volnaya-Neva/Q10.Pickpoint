namespace Q10.Pickpoint.Models.JsonModel;

public class Json60662
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
        public string Stopname { get; set; }
        public int Stopid { get; set; }
        public string StationName { get; set; }
        public string Street { get; set; }
        public object Direction { get; set; }
        public object Pavilion { get; set; }
        public string OperatingOrgName { get; set; }
        public long GlobalId { get; set; }
    }

}