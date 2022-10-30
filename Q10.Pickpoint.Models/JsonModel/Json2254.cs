namespace Q10.Pickpoint.Models.JsonModel;

public class Json2254
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
        public string Address { get; set; }
        public string WebSite { get; set; }
        public string Infrastructure { get; set; }
        public long GlobalId { get; set; }
        public int PublicPhoneisdeleted0 { get; set; }
        public string PublicPhonePublicPhone0 { get; set; }
        public int PublicPhoneGlobalId0 { get; set; }
        public int Specialtyisdeleted0 { get; set; }
        public string SpecialtySpecialty0 { get; set; }
        public int SpecialtyGlobalId0 { get; set; }
    }

}