namespace Q10.Pickpoint.Models.JsonModel;

public class Json1661
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
        public int OpopNumber { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string ExtraInfo { get; set; }
        public int GlobalId { get; set; }
        public int PublicPhoneisDeleted0 { get; set; }
        public string PublicPhonePhone0 { get; set; }
        public int PublicPhoneGlobalId0 { get; set; }
        public int PublicPhoneisDeleted1 { get; set; }
        public string PublicPhonePhone1 { get; set; }
        public int PublicPhoneGlobalId1 { get; set; }
    }

}