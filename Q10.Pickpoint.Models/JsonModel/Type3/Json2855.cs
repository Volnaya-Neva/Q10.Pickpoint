namespace Q10.Pickpoint.Models.JsonModel.Type3;

public class Json2855 : JsonType3
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
        public object[][] Coordinates { get; set; }
        public string Type { get; set; }
        public Geometry1[] Geometries { get; set; }
    }

    public class Geometry1
    {
        public object[][] Coordinates { get; set; }
        public string Type { get; set; }
    }

    public class Properties
    {
        public string OrderNumber { get; set; }
        public string CustomerConstruction { get; set; }
        public string GeneralContractor { get; set; }
        public string EarthworkObjectives { get; set; }
        public string ObjectivesOfTheInstallationOfTemporaryFences { get; set; }
        public string ObjectivesOfThePlacementOfTemporaryObjects { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string AddressOfNearbyBuilding { get; set; }
        public string WorkPlaceDescription { get; set; }
        public string WorkStartDate { get; set; }
        public string WorkEndDate { get; set; }
        public string ObjectPurpose { get; set; }
        public long GlobalId { get; set; }
        public string WorkType { get; set; }
    }

}