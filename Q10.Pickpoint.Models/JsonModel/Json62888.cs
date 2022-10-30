namespace Q10.Pickpoint.Models.JsonModel;

public class Json62888
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
        public long GlobalId { get; set; }
        public Railwaystation RailwayStation { get; set; }
    }

    public class Aeroexpressstation
    {
        public int GlobalId { get; set; }
        public string Value { get; set; }
    }

    public class Railwaystation
    {
        public int GlobalId { get; set; }
        public string Value { get; set; }
    }

}