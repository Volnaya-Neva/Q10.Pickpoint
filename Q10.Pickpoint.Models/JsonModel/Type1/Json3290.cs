namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json3290 : JsonType1
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
        public string TpuName { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string NearStation { get; set; }
        public string Holder { get; set; }
        public string AvailableTransfer { get; set; }
        public int GlobalId { get; set; }
    }

}