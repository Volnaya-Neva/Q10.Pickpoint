namespace Q10.Pickpoint.Models.JsonModel;

public class Json60413
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
        public int GlobalId { get; set; }
        public int Iden { get; set; }
        public string Addressen { get; set; }
        public object AdmAreaen { get; set; }
        public object Districten { get; set; }
        public string Perioden { get; set; }
        public string WorkingHoursen { get; set; }
        public string WorkingHoursWeekenden { get; set; }
        public string WebSiteen { get; set; }
        public int AmountOfPlacesen { get; set; }
        public object EventNameen { get; set; }
    }

}