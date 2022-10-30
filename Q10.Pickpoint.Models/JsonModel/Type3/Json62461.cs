namespace Q10.Pickpoint.Models.JsonModel.Type3;

public class Json62461 : JsonType3
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
    }

    public class Properties
    {
        public string EmCallDate { get; set; }
        public string WorkType { get; set; }
        public string LeadOfWork { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string AddressOfNearbyBuilding { get; set; }
        public string WorkPlaceDescription { get; set; }
        public string AccidentObject { get; set; }
        public string SignOfEmergency { get; set; }
        public string PlannedStartDate { get; set; }
        public string PlannedEndDate { get; set; }
        public string ActualStartDate { get; set; }
        public string ActualEndDate { get; set; }
        public string WorkStatus { get; set; }
        public string PlannedDateRestorationOfImprovement { get; set; }
        public string ActualDateRestorationOfImprovement { get; set; }
        public long GlobalId { get; set; }
    }

}