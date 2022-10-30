namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json2889 : JsonType1
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
        public string ShortDescriptionen { get; set; }
        public string AdmAreaen { get; set; }
        public string Districten { get; set; }
        public string Addressen { get; set; }
        public string LocationClarificationen { get; set; }
        public string Tariffsen { get; set; }
        public int? Yearen { get; set; }
        public string Specializationen { get; set; }
        public string Siteen { get; set; }
        public int GlobalId { get; set; }
        public int ContactPhoneenisdeleted0 { get; set; }
        public string ContactPhoneenContactPhoneen0 { get; set; }
        public int ContactPhoneenGlobalId0 { get; set; }
        public int Emailenisdeleted0 { get; set; }
        public string EmailenEmailen0 { get; set; }
        public int EmailenGlobalId0 { get; set; }
    }

}