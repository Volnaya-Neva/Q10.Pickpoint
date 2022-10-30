namespace Q10.Pickpoint.Models.JsonModel;

public class Json62603
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
        public string Street { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string DirectionOfMovement { get; set; }
        public string OppositeLane { get; set; }
        public string TwoCarriageways { get; set; }
        public string CommissioningDate { get; set; }
        public long GlobalId { get; set; }
    }

}