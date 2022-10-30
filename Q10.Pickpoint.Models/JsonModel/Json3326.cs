namespace Q10.Pickpoint.Models.JsonModel;

public class Json3326
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
        public string CommonName { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string ZipCode { get; set; }
        public string Address { get; set; }
        public string LegalAddress { get; set; }
        public string ChiefPosition { get; set; }
        public string ChiefName { get; set; }
        public string BaseDoc { get; set; }
        public string Fax { get; set; }
        public string Bank { get; set; }
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public string Ogrn { get; set; }
        public string StateAccStatus { get; set; }
        public string StateAccNum { get; set; }
        public string StateAccDocSer { get; set; }
        public string StateAccDocNum { get; set; }
        public string StateAccDate { get; set; }
        public string StateAccExp { get; set; }
        public string LicStatus { get; set; }
        public string LicNum { get; set; }
        public string LicDocSer { get; set; }
        public string LicDocNum { get; set; }
        public string LicDate { get; set; }
        public string LicExp { get; set; }
        public string TypeOfOwnership { get; set; }
        public string Subord { get; set; }
        public long GlobalId { get; set; }
    }

}