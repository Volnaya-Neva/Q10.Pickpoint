namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json61355 : JsonType1
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
        public string Name { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string Unom { get; set; }
        public float FacilityArea { get; set; }
        public Parkname ParkName { get; set; }
        public string ObjectType { get; set; }
        public string Specialization { get; set; }
        public string PeriodOfPlacement { get; set; }
        public string ContractType { get; set; }
        public string ContractStatus { get; set; }
        public string ContractNumber { get; set; }
        public string NameOfBusinessEntity { get; set; }
        public string ContractBegin { get; set; }
        public string ContractEnd { get; set; }
        public string ContractBasis { get; set; }
        public string ObjectPhoto { get; set; }
        public string StartDateTrading { get; set; }
        public string EndDateTrading { get; set; }
        public int GlobalId { get; set; }
    }

    public class Parkname
    {
        public long GlobalId { get; set; }
        public string Value { get; set; }
    }

}