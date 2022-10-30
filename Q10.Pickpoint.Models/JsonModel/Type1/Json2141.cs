namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json2141 : JsonType1
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
        public int IdEn { get; set; }
        public string AddressEn { get; set; }
        public object AdmAreaEn { get; set; }
        public object DistrictEn { get; set; }
        public object StatusFairsEn { get; set; }
        public string PeriodOfPlacementEn { get; set; }
        public object GoodsCategoryEn { get; set; }
        public string SituationalPlanEn { get; set; }
        public int AmountOfPlacesEn { get; set; }
        public string LongitudeWgs84En { get; set; }
        public string LatitudeWgs84En { get; set; }
        public string UnomEn { get; set; }
        public object EntryStateEn { get; set; }
        public string PhotoEn { get; set; }
        public long GlobalId { get; set; }
    }

}