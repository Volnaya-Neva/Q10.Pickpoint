namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json3401 : JsonType1
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
        public string FullNameOrg { get; set; }
        public string Leader { get; set; }
        public string Position { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int Beds { get; set; }
        public string AgeGroup { get; set; }
        public string IsAmbulance { get; set; }
        public int GlobalId { get; set; }
    }

}