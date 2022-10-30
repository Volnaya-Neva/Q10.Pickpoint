namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json61861 : JsonType1
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
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public string ShortDescription { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string LocationClarification { get; set; }
        public string Tariffs { get; set; }
        public string WorkplaceTerms { get; set; }
        public string WorkplaceTime { get; set; }
        public int? YearOfCreation { get; set; }
        public string Specialization { get; set; }
        public string Site { get; set; }
        public int GlobalId { get; set; }
        public int ContactPhoneisDeleted0 { get; set; }
        public int ContactPhoneGlobalId0 { get; set; }
        public string ContactPhonesystemObjectId0 { get; set; }
        public string ContactPhoneContactPhone0 { get; set; }
        public int EmailisDeleted0 { get; set; }
        public int EmailGlobalId0 { get; set; }
        public string EmailEmail0 { get; set; }
    }

}