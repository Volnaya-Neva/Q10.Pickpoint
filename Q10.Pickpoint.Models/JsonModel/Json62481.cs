namespace Q10.Pickpoint.Models.JsonModel;

public class Json62481
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
        public string TypeEvent { get; set; }
        public string Name { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string ClarificationVenueEvent { get; set; }
        public int Year { get; set; }
        public string MonthEvent { get; set; }
        public string Date { get; set; }
        public string ResponsibleEvent { get; set; }
        public string DescriptionEvent { get; set; }
        public long GlobalId { get; set; }
    }

}