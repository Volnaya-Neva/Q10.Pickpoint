namespace Q10.Pickpoint.Models.JsonModel;

public class Json1470
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
        public string Location { get; set; }
        public string LocationClarification { get; set; }
        public string WebSite { get; set; }
        public string ExtraInfo { get; set; }
        public int GlobalId { get; set; }
        public int ShowTimesGlobalId0 { get; set; }
        public int ShowTimesisDeleted0 { get; set; }
        public int CostGlobalId0 { get; set; }
        public int CostisDeleted0 { get; set; }
        public int CostGlobalId1 { get; set; }
        public int CostisDeleted1 { get; set; }
        public int CostGlobalId2 { get; set; }
        public int CostisDeleted2 { get; set; }
        public int PhoneGlobalId0 { get; set; }
        public int PhoneisDeleted0 { get; set; }
        public string NearestMetroStation { get; set; }
        public int PhoneGlobalId1 { get; set; }
        public int PhoneisDeleted1 { get; set; }
        public int ShowTimesGlobalId1 { get; set; }
        public int ShowTimesisDeleted1 { get; set; }
        public int ShowTimesGlobalId2 { get; set; }
        public int ShowTimesisDeleted2 { get; set; }
        public int CostGlobalId3 { get; set; }
        public int CostisDeleted3 { get; set; }
        public int CostGlobalId4 { get; set; }
        public int CostisDeleted4 { get; set; }
        public int CostGlobalId5 { get; set; }
        public int CostisDeleted5 { get; set; }
        public int CostGlobalId6 { get; set; }
        public int CostisDeleted6 { get; set; }
    }

}