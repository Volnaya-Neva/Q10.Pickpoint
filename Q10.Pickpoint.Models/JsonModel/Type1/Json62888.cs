namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json62888 : JsonType1
{
    public class Properties
    {
        public string StationName { get; set; }
        public string TransliterationStation { get; set; }
        public string DiameterName { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Area { get; set; }
        public string Tariff { get; set; }
        public int Platforms { get; set; }
        public string MaskStation { get; set; }
        public object TransferMcd { get; set; }
        public string TransferAeroExpress { get; set; }
        public Aeroexpressstation AeroexpressStation { get; set; }
        public string ExitTrainStations { get; set; }
        public string ObjectStatus { get; set; }
        public string GlobalId { get; set; }
        public Railwaystation RailwayStation { get; set; }
    }

    public class Aeroexpressstation
    {
        public string GlobalId { get; set; }
        public string Value { get; set; }
    }

    public class Railwaystation
    {
        public string GlobalId { get; set; }
        public string Value { get; set; }
    }

}