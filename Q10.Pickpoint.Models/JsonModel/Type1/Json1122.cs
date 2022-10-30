namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json1122 : JsonType1
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
        public string NumberOfExploitationPermission { get; set; }
        public string Owner { get; set; }
        public string ResolutionExpiryDate { get; set; }
        public string ContractNumber { get; set; }
        public string ContractExpiryDate { get; set; }
        public string ConstructionType { get; set; }
        public string IsNotOutsized { get; set; }
        public string ConstructionSize { get; set; }
        public string TechCharasteristics { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string Location { get; set; }
        public string LocationClarification { get; set; }
        public string IsOnScheme { get; set; }
        public string NumberOnScheme { get; set; }
        public string LongitudeWgs84 { get; set; }
        public string LatitudeWgs84 { get; set; }
        public string OldNumberOfExploitationPermission { get; set; }
        public long GlobalId { get; set; }
    }

}