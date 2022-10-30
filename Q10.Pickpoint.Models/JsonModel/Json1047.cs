namespace Q10.Pickpoint.Models.JsonModel;

public class Json1047
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
        public string YearOfComissioning { get; set; }
        public string Status { get; set; }
        public string AvailableTransfer { get; set; }
        public int? CarCapacity { get; set; }
        public int GlobalId { get; set; }
    }

}