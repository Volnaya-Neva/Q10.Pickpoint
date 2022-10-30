namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json673 : JsonType1
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
        public string BoothNumber { get; set; }
        public string ActualLocaton { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string Location { get; set; }
        public string StreetName { get; set; }
        public string ClarificationOfWorkingHours { get; set; }
        public string Unom { get; set; }
        public string OnTerritoryOfMoscow { get; set; }
        public string WorkingHours { get; set; }
        public string PointType { get; set; }
        public string PaymentType { get; set; }
        public long GlobalId { get; set; }
    }

}