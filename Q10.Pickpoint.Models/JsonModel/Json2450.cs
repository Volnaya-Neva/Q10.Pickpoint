namespace Q10.Pickpoint.Models.JsonModel;

public class Json2450
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
        public int Period { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public long GlobalId { get; set; }
        public int Conditionsisdeleted0 { get; set; }
        public object ConditionsConditionName0 { get; set; }
        public object ConditionsPercentValue0 { get; set; }
        public int ConditionsGlobalId0 { get; set; }
        public int Conditionsisdeleted1 { get; set; }
        public object ConditionsConditionName1 { get; set; }
        public object ConditionsPercentValue1 { get; set; }
        public int ConditionsGlobalId1 { get; set; }
        public int Conditionsisdeleted2 { get; set; }
        public object ConditionsConditionName2 { get; set; }
        public object ConditionsPercentValue2 { get; set; }
        public int ConditionsGlobalId2 { get; set; }
    }

}