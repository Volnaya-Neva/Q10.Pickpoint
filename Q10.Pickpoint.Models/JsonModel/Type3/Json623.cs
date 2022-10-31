namespace Q10.Pickpoint.Models.JsonModel.Type3;

public class Json623 : JsonType3
{
    public class Properties
    {
        public string ParkingName { get; set; }
        public string ParkingZoneNumber { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public int CarCapacity { get; set; }
        public int CarCapacityDisabled { get; set; }
        public string GlobalId { get; set; }
    }
}