namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json1200 : JsonType1
{
    public class Properties
    {
        public string ShortName { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public int Index { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string ClarificationOfVisitingHours { get; set; }
        public string ChiefName { get; set; }
        public string ClarificationOfDocumentsIssuanceHours { get; set; }
        public string ExtraInfo { get; set; }
        public string GlobalId { get; set; }
    }
}