namespace Q10.Pickpoint.Models.JsonModel;

public class Json2208
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
        public string AdmAreaen { get; set; }
        public string Districten { get; set; }
        public string Addressen { get; set; }
        public int GlobalId { get; set; }
        public int Phoneenisdeleted0 { get; set; }
        public string PhoneenPhoneen0 { get; set; }
        public int PhoneenGlobalId0 { get; set; }
    }

}