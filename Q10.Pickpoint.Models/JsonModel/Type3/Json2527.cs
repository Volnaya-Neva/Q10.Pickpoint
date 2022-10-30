namespace Q10.Pickpoint.Models.JsonModel.Type3;

public class Json2527 : JsonType3
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
        public float[][][] Coordinates { get; set; }
        public string Type { get; set; }
    }

    public class Properties
    {
        public string Address { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string Eventtype { get; set; }
        public string Name { get; set; }
        public string Requester { get; set; }
        public string Sfrom { get; set; }
        public string Sto { get; set; }
        public string Lanesclosed { get; set; }
        public string Descr { get; set; }
        public int GlobalId { get; set; }
    }

}