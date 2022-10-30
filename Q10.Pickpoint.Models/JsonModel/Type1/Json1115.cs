namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json1115 : JsonType1
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
        public string N { get; set; }
        public object Lot { get; set; }
        public string Date { get; set; }
        public string Okrug { get; set; }
        public string Address { get; set; }
        public string Unom { get; set; }
        public string Characteristic { get; set; }
        public object ReestrNumber { get; set; }
        public string S { get; set; }
        public string FirstPrice { get; set; }
        public object Bti { get; set; }
        public object StartDate { get; set; }
        public object AndDate { get; set; }
        public object DeterminetionDate { get; set; }
        public object FotoMap { get; set; }
        public string Comment { get; set; }
        public string XWgs { get; set; }
        public string YWgs { get; set; }
        public string GlobalId { get; set; }
    }

}