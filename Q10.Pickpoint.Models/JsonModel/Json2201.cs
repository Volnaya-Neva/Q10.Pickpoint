namespace Q10.Pickpoint.Models.JsonModel;

public class Json2201
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
        public string OnTerritoryOfMoscowen { get; set; }
        public string AdmAreaen { get; set; }
        public string Districten { get; set; }
        public string Addressen { get; set; }
        public string LongitudeWgs84En { get; set; }
        public string LatitudeWgs84En { get; set; }
        public float? ObjectAreaen { get; set; }
        public string ObjectStatusen { get; set; }
        public int GlobalId { get; set; }
        public int ContactPhoneenisdeleted0 { get; set; }
        public string ContactPhoneenContactPhoneen0 { get; set; }
        public int ContactPhoneenGlobalId0 { get; set; }
        public string GraveTypeen { get; set; }
    }

}