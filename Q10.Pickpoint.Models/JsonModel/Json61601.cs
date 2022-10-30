namespace Q10.Pickpoint.Models.JsonModel;

public class Json61601
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
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string NameOfResponsiblePerson { get; set; }
        public string PositionOfResponsiblePerson { get; set; }
        public string PlaceOfReceptionOfCitizens { get; set; }
        public string Comment { get; set; }
        public int GlobalId { get; set; }
        public int PublicPhoneisdeleted0 { get; set; }
        public int PublicPhoneGlobalId0 { get; set; }
        public string PublicPhonePublicPhone0 { get; set; }
        public int PublicPhoneisdeleted1 { get; set; }
        public int PublicPhoneGlobalId1 { get; set; }
        public string PublicPhonePublicPhone1 { get; set; }
        public int ReceptionTimeOfCitizensisdeleted0 { get; set; }
        public int ReceptionTimeOfCitizensGlobalId0 { get; set; }
        public object ReceptionTimeOfCitizensDayOfWeek0 { get; set; }
        public string ReceptionTimeOfCitizensHours0 { get; set; }
        public int ReceptionTimeOfCitizensisdeleted1 { get; set; }
        public int ReceptionTimeOfCitizensGlobalId1 { get; set; }
        public object ReceptionTimeOfCitizensDayOfWeek1 { get; set; }
        public string ReceptionTimeOfCitizensHours1 { get; set; }
    }

}