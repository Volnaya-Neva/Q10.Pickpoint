namespace Q10.Pickpoint.Models.JsonModel;

public class Json1581
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
        public string Name { get; set; }
        public string DistributorNetwork { get; set; }
        public string LegalEntity { get; set; }
        public string Category { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string CardTypes { get; set; }
        public string Phone { get; set; }
        public float MinDiscount { get; set; }
        public float MaxDiscount { get; set; }
        public string TermsDiscount { get; set; }
        public string ExtraInfo { get; set; }
        public string WebSite { get; set; }
        public string Inn { get; set; }
        public string OnTerritoryOfMoscow { get; set; }
        public long GlobalId { get; set; }
        public string CategoriesofHolders { get; set; }
    }

}