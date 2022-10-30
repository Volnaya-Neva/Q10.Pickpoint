namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json1663 : JsonType1
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
        public string DepartmentalAffiliation { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string Location { get; set; }
        public string LocationClarification { get; set; }
        public string Email { get; set; }
        public string WebSite { get; set; }
        public string HelpPhone { get; set; }
        public string ObjectHasDressingRoom { get; set; }
        public string ObjectHasEatery { get; set; }
        public string ObjectHasToilet { get; set; }
        public string ObjectHasWifi { get; set; }
        public string ObjectHasFirstAidPost { get; set; }
        public string WorkingHours { get; set; }
        public int IceHolesCount { get; set; }
        public int FontsCount { get; set; }
        public int GlobalId { get; set; }
    }

}