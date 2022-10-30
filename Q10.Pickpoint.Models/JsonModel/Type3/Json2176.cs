namespace Q10.Pickpoint.Models.JsonModel.Type3;

public class Json2176 : JsonType3
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
        public string BalanceHolderNameen { get; set; }
        public string DepartmentalAffiliationen { get; set; }
        public int GlobalId { get; set; }
    }

}