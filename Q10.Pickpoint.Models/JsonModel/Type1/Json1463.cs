namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json1463 : JsonType1
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
        public string Address { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string ObjectCharacteristic { get; set; }
        public int Space { get; set; }
        public float InitialSizeOfAnnualRent { get; set; }
        public string IntendedNonresidentialObjectUse { get; set; }
        public string Stage { get; set; }
        public string TradesDate { get; set; }
        public object Sold { get; set; }
        public string ExtraInfo { get; set; }
        public string ConditionalNumber { get; set; }
        public string StageClarification { get; set; }
        public string StartReceptionDate { get; set; }
        public string EndReceptionDate { get; set; }
        public int GlobalId { get; set; }
        public int WebSiteisDeleted0 { get; set; }
        public string WebSiteWebSite0 { get; set; }
        public int WebSiteGlobalId0 { get; set; }
        public int PhotoisDeleted0 { get; set; }
        public int PhotoGlobalId0 { get; set; }
        public string PhotoPhoto0 { get; set; }
    }

}