namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json61802 : JsonType1
{
    public class Properties
    {
        public int IdEn { get; set; }
        public object AdmAreaEn { get; set; }
        public object DistrictEn { get; set; }
        public NameofparkEn NameOfParkEn { get; set; }
        public object ObjectTypeEn { get; set; }
        public string NameEn { get; set; }
        public string LocationEn { get; set; }
        public string LongitudeWgs84En { get; set; }
        public string LatitudeWgs84En { get; set; }
        public string WorkingHoursEn { get; set; }
        public string PaidServiceEn { get; set; }
        public object InventoryRentalEn { get; set; }
        public object HasDressingRoomEn { get; set; }
        public object SharpeningSkatesEn { get; set; }
        public object HireSkatersAssistantsEn { get; set; }
        public int? SquareEn { get; set; }
        public float? LengthEn { get; set; }
        public object LightingAvailabilityEn { get; set; }
        public string GlobalId { get; set; }
    }

    public class NameofparkEn
    {
        public string GlobalId { get; set; }
        public string Value { get; set; }
    }

}