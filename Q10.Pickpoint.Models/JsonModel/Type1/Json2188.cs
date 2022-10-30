namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json2188 : JsonType1
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
        public object AdmAreaen { get; set; }
        public object Districten { get; set; }
        public string Addressen { get; set; }
        public string RegionOfFairen { get; set; }
        public string PeriodOfPlacementen { get; set; }
        public string Goodsen { get; set; }
        public long GlobalId { get; set; }
    }

}