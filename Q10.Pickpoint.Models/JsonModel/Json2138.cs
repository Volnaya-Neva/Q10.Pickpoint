namespace Q10.Pickpoint.Models.JsonModel;

public class Json2138
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
        public string NameEn { get; set; }
        public string InnEn { get; set; }
        public string KppEn { get; set; }
        public string OgrnEn { get; set; }
        public string CategoriesEn { get; set; }
        public object AdmAreaEn { get; set; }
        public object DistrictEn { get; set; }
        public string AddressEn { get; set; }
        public string WebSiteEn { get; set; }
        public int GlobalId { get; set; }
    }

}