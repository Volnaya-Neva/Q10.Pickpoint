namespace Q10.Pickpoint.Models.JsonModel;

public class Json587
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
        public string Id { get; set; }
        public string StationaryObjectName { get; set; }
        public string Owner { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public float FacilityArea { get; set; }
        public string LongitudeWgs84 { get; set; }
        public string LatitudeWgs84 { get; set; }
        public string EntryState { get; set; }
        public string EntryModifyReason { get; set; }
        public object EntryDeleteReason { get; set; }
        public string ObjectType { get; set; }
        public string Unom { get; set; }
        public string MvkRecordNumberModify { get; set; }
        public string MvkRecordDateModify { get; set; }
        public string MvkRecordNumberRemove { get; set; }
        public string MvkRecordDateRemove { get; set; }
        public long GlobalId { get; set; }
    }

}