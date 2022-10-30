namespace Q10.Pickpoint.Models.JsonModel;

public class Json3251
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
        public float[][] Coordinates { get; set; }
        public string Type { get; set; }
    }

    public class Properties
    {
        public int Year { get; set; }
        public string Name { get; set; }
        public string DateRegistration { get; set; }
        public string LegalAddress { get; set; }
        public string Addresses { get; set; }
        public string Inn { get; set; }
        public string Ogrn { get; set; }
        public string DateLastCheck { get; set; }
        public string Purpose { get; set; }
        public string Month { get; set; }
        public int NumberDays { get; set; }
        public string TypeOfCheck { get; set; }
        public long GlobalId { get; set; }
        public int NameControllingAuthorityisdeleted0 { get; set; }
        public int NameControllingAuthorityGlobalId0 { get; set; }
        public string NameControllingAuthorityNameControllingAuthority0 { get; set; }
        public int NameControllingAuthorityisdeleted1 { get; set; }
        public int NameControllingAuthorityGlobalId1 { get; set; }
        public string NameControllingAuthorityNameControllingAuthority1 { get; set; }
        public int NameControllingAuthorityisdeleted2 { get; set; }
        public int NameControllingAuthorityGlobalId2 { get; set; }
        public string NameControllingAuthorityNameControllingAuthority2 { get; set; }
        public int NameControllingAuthorityisdeleted3 { get; set; }
        public int NameControllingAuthorityGlobalId3 { get; set; }
        public string NameControllingAuthorityNameControllingAuthority3 { get; set; }
        public int NameControllingAuthorityisdeleted4 { get; set; }
        public int NameControllingAuthorityGlobalId4 { get; set; }
        public string NameControllingAuthorityNameControllingAuthority4 { get; set; }
        public int NameControllingAuthorityisdeleted5 { get; set; }
        public int NameControllingAuthorityGlobalId5 { get; set; }
        public string NameControllingAuthorityNameControllingAuthority5 { get; set; }
        public int NameControllingAuthorityisdeleted6 { get; set; }
        public int NameControllingAuthorityGlobalId6 { get; set; }
        public string NameControllingAuthorityNameControllingAuthority6 { get; set; }
    }

}