namespace Q10.Pickpoint.Models.JsonModel;

public class Json6452
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
        public int IdEn { get; set; }
        public string NameEn { get; set; }
        public string AdmAreaEn { get; set; }
        public string DistrictEn { get; set; }
        public string LocationEn { get; set; }
        public string LocationClarificationEn { get; set; }
        public int MaxPeopleEn { get; set; }
        public string DepartmentalAffiliationEn { get; set; }
        public int GlobalId { get; set; }
    }

}