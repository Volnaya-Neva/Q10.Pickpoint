namespace Q10.Pickpoint.Models.JsonModel;

public class Json62061
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
        public string FairName { get; set; }
        public string FairStatus { get; set; }
        public float FairTotalArea { get; set; }
        public int SeatsNumber { get; set; }
        public string FairType { get; set; }
        public string Goods { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string FunctionalZoning { get; set; }
        public string AdditionalInformation { get; set; }
        public long GlobalId { get; set; }
    }

}