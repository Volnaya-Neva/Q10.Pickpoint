namespace Q10.Pickpoint.Models.JsonModel.Type3;

public class Json62601 : JsonType3
{
    public class Properties
    {
        public string Street { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public int SpeedLimit { get; set; }
        public string TransportLimit { get; set; }
        public string TimeLimit { get; set; }
        public string RoadConditionsLimit { get; set; }
        public string CommissioningDate { get; set; }
        public string GlobalId { get; set; }
    }
}