namespace Q10.Pickpoint.Models.JsonModel.Type3;

public class Json1465 : JsonType3
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
        public object[][][] Coordinates { get; set; }
        public string Type { get; set; }
    }

    public class Properties
    {
        public string CommonName { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string Location { get; set; }
        public string BalanceholderComp { get; set; }
        public string BalanceholderInn { get; set; }
        public string BalanceholderKpp { get; set; }
        public string BalanceholderOgrn { get; set; }
        public string BalanceholderWebSite { get; set; }
        public string NeighbourhoodPark { get; set; }
        public string HasWater { get; set; }
        public string HasPlayground { get; set; }
        public string HasSportground { get; set; }
        public string DepartamentalAffiliationComp { get; set; }
        public string ParkWebSite { get; set; }
        public string OperationOrganizationName { get; set; }
        public string OperationOrganizationWebSite { get; set; }
        public string ClarificationOfWorkingHours { get; set; }
        public string CreateEntries { get; set; }
        public string EntranceAdditionalInformation { get; set; }
        public long GlobalId { get; set; }
    }

}