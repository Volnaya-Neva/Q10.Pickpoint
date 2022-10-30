namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json2185 : JsonType1
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
        public string CommonNameen { get; set; }
        public string FullNameen { get; set; }
        public string ShortNameen { get; set; }
        public string AdmAreaCodeen { get; set; }
        public object AdmAreaen { get; set; }
        public object Districten { get; set; }
        public string PostalCodeen { get; set; }
        public string Addressen { get; set; }
        public string ChiefNameen { get; set; }
        public string ChiefPositionen { get; set; }
        public string SignPgUen { get; set; }
        public string ClarificationOfWorkingHoursen { get; set; }
        public string WebSiteen { get; set; }
        public string InNen { get; set; }
        public string UnoMen { get; set; }
        public object EntryStateen { get; set; }
        public int GlobalId { get; set; }
    }

}