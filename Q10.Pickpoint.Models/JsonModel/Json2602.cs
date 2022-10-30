namespace Q10.Pickpoint.Models.JsonModel;

public class Json2602
{
    public Feature[] Features { get; set; }
    public string Type { get; set; }

    public class Feature
    {
        public object Geometry { get; set; }
        public Properties Properties { get; set; }
        public string Type { get; set; }
    }

    public class Properties
    {
        public string Nameen { get; set; }
        public string LegalAddressen { get; set; }
        public string PublicPhoneen { get; set; }
        public string Emailen { get; set; }
        public string ExtraInfoen { get; set; }
        public long GlobalId { get; set; }
    }

}