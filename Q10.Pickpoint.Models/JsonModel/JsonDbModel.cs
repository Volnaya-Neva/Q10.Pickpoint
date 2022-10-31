namespace Q10.Pickpoint.Models.JsonModel;

public class JsonDbModel
{
    public int Number { get; set; }
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
        public float[][] Coordinates2 { get; set; }
        public float[][][] Coordinates3 { get; set; }
        public string Type { get; set; }
    }

    public class Properties //Над отобрать необходимые поля
    {
        public string CommonName { get; set; }
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public string Area { get; set; }
        public string Address { get; set; }
        public string GlobalId { get; set; }
    }
}