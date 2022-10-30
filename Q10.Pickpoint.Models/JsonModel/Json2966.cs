namespace Q10.Pickpoint.Models.JsonModel;

public class Json2966
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
        public string FullNameen { get; set; }
        public string AdmAreaen { get; set; }
        public string Districten { get; set; }
        public string Locationen { get; set; }
        public string WorkingHoursen { get; set; }
        public string ExtraInfoen { get; set; }
        public string LongitudeWgs84En { get; set; }
        public string LattitudeWgs84En { get; set; }
        public int GlobalId { get; set; }
    }

}