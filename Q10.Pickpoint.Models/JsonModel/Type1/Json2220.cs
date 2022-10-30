namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json2220 : JsonType1
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
        public string ParkingNameen { get; set; }
        public string MetroStationen { get; set; }
        public string MetroLineen { get; set; }
        public string AdmAreaen { get; set; }
        public string Districten { get; set; }
        public string LocationDescriptionen { get; set; }
        public string Scheduleen { get; set; }
        public string OrgPhoneen { get; set; }
        public int CarCapacityen { get; set; }
        public string LongitudeWgs84En { get; set; }
        public string LatitudeWgs84En { get; set; }
        public long GlobalId { get; set; }
    }

}