namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json62891 : JsonType1
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
        public int Iden { get; set; }
        public string Nameen { get; set; }
        public object Stationen { get; set; }
        public object RailwayLineen { get; set; }
        public string WorkingHoursen { get; set; }
        public string LatitudeWgs84En { get; set; }
        public string LongitudeWgs84En { get; set; }
        public object ObjectStatusen { get; set; }
        public long GlobalId { get; set; }
    }

}