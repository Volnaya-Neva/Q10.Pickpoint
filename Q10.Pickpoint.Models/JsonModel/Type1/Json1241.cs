namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json1241 : JsonType1
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
        public string PeriodOfPlacement { get; set; }
        public string BeginDate { get; set; }
        public string EndDate { get; set; }
        public string CertificateNum { get; set; }
        public string CertificateIssueDate { get; set; }
        public float FacilityArea { get; set; }
        public string ContractStatus { get; set; }
        public string ContractNumber { get; set; }
        public string NameOfBusinessEntity { get; set; }
        public string PrefectOrderNumber { get; set; }
        public string PrefectOrderDate { get; set; }
        public string Unom { get; set; }
        public int GlobalId { get; set; }
    }

}