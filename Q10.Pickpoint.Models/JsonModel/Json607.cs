namespace Q10.Pickpoint.Models.JsonModel;

public class Json607
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
        public string Name { get; set; }
        public string OnTerritoryOfMoscow { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string LongitudeWgs84 { get; set; }
        public string LatitudeWgs84 { get; set; }
        public float? ObjectArea { get; set; }
        public string ObjectStatus { get; set; }
        public int GlobalId { get; set; }
        public int ContactPhoneisdeleted0 { get; set; }
        public string ContactPhoneContactPhone0 { get; set; }
        public int ContactPhoneGlobalId0 { get; set; }
        public string GraveType { get; set; }
    }

}