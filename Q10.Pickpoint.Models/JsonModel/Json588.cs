namespace Q10.Pickpoint.Models.JsonModel;

public class Json588
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
        public string Address { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public int TotalParkingSlots { get; set; }
        public string ConstructionBegin { get; set; }
        public string ConstructionEnd { get; set; }
        public int GlobalId { get; set; }
    }

}