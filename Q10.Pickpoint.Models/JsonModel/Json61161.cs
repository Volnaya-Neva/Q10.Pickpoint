namespace Q10.Pickpoint.Models.JsonModel;

public class Json61161
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
        public string SurveyDate { get; set; }
        public string AdmArea { get; set; }
        public string ContObjectName { get; set; }
        public string AffiliationDep { get; set; }
        public string BalanceHolderName { get; set; }
        public string RespContrOrganization { get; set; }
        public string Location { get; set; }
        public string TypeOfViolation { get; set; }
        public string ViolationNature { get; set; }
        public string Photo { get; set; }
        public long GlobalId { get; set; }
    }

}