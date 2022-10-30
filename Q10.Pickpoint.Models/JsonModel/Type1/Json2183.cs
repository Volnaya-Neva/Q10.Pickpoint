namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json2183 : JsonType1
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
        public string Owneren { get; set; }
        public string InNen { get; set; }
        public string KpPen { get; set; }
        public string OgrNen { get; set; }
        public string AdmAreaen { get; set; }
        public string Districten { get; set; }
        public string Addressen { get; set; }
        public int DailyOutputen { get; set; }
        public string LongitudeWgs84En { get; set; }
        public string LatitudeWgs84En { get; set; }
        public int GlobalId { get; set; }
    }

}