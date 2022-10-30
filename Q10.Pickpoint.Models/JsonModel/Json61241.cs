namespace Q10.Pickpoint.Models.JsonModel;

public class Json61241
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
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string NumberRoom { get; set; }
        public string DepartmentalAffiliation { get; set; }
        public string PrefectOrderNumber { get; set; }
        public string DatePrefectDisposal { get; set; }
        public string Decision { get; set; }
        public long GlobalId { get; set; }
    }

}