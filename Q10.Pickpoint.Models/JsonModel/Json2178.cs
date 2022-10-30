namespace Q10.Pickpoint.Models.JsonModel;

public class Json2178
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
        public int Iden { get; set; }
        public string FullNameen { get; set; }
        public string ShortNameen { get; set; }
        public string InNen { get; set; }
        public string KpPen { get; set; }
        public string OgrNen { get; set; }
        public string AdmAreaen { get; set; }
        public string Districten { get; set; }
        public string Addressen { get; set; }
        public string WebSiteen { get; set; }
        public int GlobalId { get; set; }
        public int ContactPhoneenisdeleted0 { get; set; }
        public string ContactPhoneenContactPhoneen0 { get; set; }
        public int ContactPhoneenGlobalId0 { get; set; }
        public int Faxenisdeleted0 { get; set; }
        public string FaxenFaxen0 { get; set; }
        public int FaxenGlobalId0 { get; set; }
        public int ContactPhoneenisdeleted1 { get; set; }
        public string ContactPhoneenContactPhoneen1 { get; set; }
        public int ContactPhoneenGlobalId1 { get; set; }
    }

}