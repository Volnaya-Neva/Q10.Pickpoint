namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json2515 : JsonType1
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
        public string Addressen { get; set; }
        public string AdmAreaen { get; set; }
        public string Districten { get; set; }
        public int TotalParkingSlotsen { get; set; }
        public string ConstructionBeginen { get; set; }
        public string ConstructionEnden { get; set; }
        public int GlobalId { get; set; }
    }

}