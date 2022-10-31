namespace Q10.Pickpoint.Models.JsonModel.TypeOther;

public class Json62501 : JsonType4
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
        public string Date { get; set; }
        public string StateCustomer { get; set; }
        public string EarthworkObjectives { get; set; }
        public string ObjectivesOfTheInstallationOfTemporaryFences { get; set; }
        public string ObjectivesOfThePlacementOfTemporaryObjects { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string AddressOfNearbyBuilding { get; set; }
        public string WorkPlaceDescription { get; set; }
        public string WorkStartDate { get; set; }
        public string WorkEndDate { get; set; }
        public string GlobalId { get; set; }
        public string WorkType { get; set; }
    }

}