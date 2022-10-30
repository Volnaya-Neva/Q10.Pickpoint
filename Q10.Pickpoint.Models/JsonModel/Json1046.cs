namespace Q10.Pickpoint.Models.JsonModel;

public class Json1046
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
        public string BalanceHolderName { get; set; }
        public string DepartmentalAffiliation { get; set; }
        public int GlobalId { get; set; }
    }
}