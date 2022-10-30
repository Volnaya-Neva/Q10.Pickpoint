namespace Q10.Pickpoint.Models.JsonModel;

public class Json841
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
        public string DescriptionLocation { get; set; }
        public string PayWay { get; set; }
        public string IntercityConnectionPayment { get; set; }
        public string ValidUniversalServicesCard { get; set; }
        public int GlobalId { get; set; }
    }

}