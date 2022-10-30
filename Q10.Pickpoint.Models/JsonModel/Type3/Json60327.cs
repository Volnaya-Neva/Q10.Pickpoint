namespace Q10.Pickpoint.Models.JsonModel.Type3;

public class Json60327 : JsonType3
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
        public string ShortNameen { get; set; }
        public string FullNameen { get; set; }
        public object ReorganizationStatusen { get; set; }
        public int IdEkiSen { get; set; }
        public int? Numberen { get; set; }
        public string InNen { get; set; }
        public string KpPen { get; set; }
        public string OgrNen { get; set; }
        public object LegalOrganizationen { get; set; }
        public object Subordinationen { get; set; }
        public string ChiefNameen { get; set; }
        public string LegalAddressen { get; set; }
        public string WebSiteen { get; set; }
        public string EducationProgramsen { get; set; }
        public object OrgTypeen { get; set; }
        public long GlobalId { get; set; }
    }

}