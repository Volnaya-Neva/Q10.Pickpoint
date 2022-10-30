namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json2116 : JsonType1
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
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string ClarificationOfLocation { get; set; }
        public string WorkingHours { get; set; }
        public string ClarificationOfWorkingHours { get; set; }
        public string BalanceHolderName { get; set; }
        public string BalanceholderPhone { get; set; }
        public string BalanceholderFax { get; set; }
        public string BalanceHolderEmail { get; set; }
        public string BalanceholderWebSite { get; set; }
        public int GlobalId { get; set; }
    }

}