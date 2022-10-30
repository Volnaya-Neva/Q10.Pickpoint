namespace Q10.Pickpoint.Models.JsonModel;

public class Json2263
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
        public object[][][] Coordinates { get; set; }
        public string Type { get; set; }
    }

    public class Properties
    {
        public string ShortName { get; set; }
        public string OrgType { get; set; }
        public string FullName { get; set; }
        public string WebSite { get; set; }
        public string Subordination { get; set; }
        public string Ogrn { get; set; }
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public string LegalOrganization { get; set; }
        public string LegalAddress { get; set; }
        public string ChiefName { get; set; }
        public string EducationPrograms { get; set; }
        public long GlobalId { get; set; }
    }

}