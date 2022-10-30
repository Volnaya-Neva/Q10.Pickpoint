namespace Q10.Pickpoint.Models.JsonModel;

public class Json2343
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
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string LegalAddress { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string WebSite { get; set; }
        public string Categorization { get; set; }
        public string CertificateNumber { get; set; }
        public string CertificateIssueDate { get; set; }
        public string NumberInFederalList { get; set; }
        public string CertificateValidity { get; set; }
        public string NameOfAccreditedOrganization { get; set; }
        public int GlobalId { get; set; }
    }

}