namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json2470 : JsonType1
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
        public string AdmArea { get; set; }
        public string District { get; set; }
        public int GlobalId { get; set; }
        public int Addressisdeleted0 { get; set; }
        public string AddressAddress0 { get; set; }
        public int AddressGlobalId0 { get; set; }
        public int Addressisdeleted1 { get; set; }
        public string AddressAddress1 { get; set; }
        public int AddressGlobalId1 { get; set; }
    }

}