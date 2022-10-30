namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json2199 : JsonType1
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
        public string Emailen { get; set; }
        public int GlobalId { get; set; }
        public int Phoneenisdeleted0 { get; set; }
        public string PhoneenPhoneen0 { get; set; }
        public int PhoneenGlobalId0 { get; set; }
        public int Phoneenisdeleted1 { get; set; }
        public string PhoneenPhoneen1 { get; set; }
        public int PhoneenGlobalId1 { get; set; }
        public int Phoneenisdeleted2 { get; set; }
        public string PhoneenPhoneen2 { get; set; }
        public int PhoneenGlobalId2 { get; set; }
        public int Phoneenisdeleted3 { get; set; }
        public string PhoneenPhoneen3 { get; set; }
        public int PhoneenGlobalId3 { get; set; }
    }

}