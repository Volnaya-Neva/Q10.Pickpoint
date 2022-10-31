namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json61356 : JsonType1
{
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
        public object ObjectPhoto { get; set; }
        public string StartDateTrading { get; set; }
        public string EndDateTrading { get; set; }
        public string GlobalId { get; set; }
    }

    public class Parkname
    {
        public string GlobalId { get; set; }
        public string Value { get; set; }
    }

}