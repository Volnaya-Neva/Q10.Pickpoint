namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json1362 : JsonType1
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
        public string Prof { get; set; }
        public string Number { get; set; }
        public string Date { get; set; }
        public int CountVacancy { get; set; }
        public string SpecialWorkPlace { get; set; }
        public string Specification { get; set; }
        public int MinZarplat { get; set; }
        public int? MaxZarplat { get; set; }
        public string WorkFunction { get; set; }
        public string WorkRegim { get; set; }
        public string WorkOsob { get; set; }
        public string Skills { get; set; }
        public string DopWorkersParameters { get; set; }
        public string WorkType { get; set; }
        public string Education { get; set; }
        public int? ProfStage { get; set; }
        public string InterviewPlaceAdmArea { get; set; }
        public string InterviewPlaceDistrict { get; set; }
        public string InterviewPlaceLocation { get; set; }
        public string InterviewPlaceNote { get; set; }
        public string WorkPlaceAdmArea { get; set; }
        public string WorkPlaceDistrict { get; set; }
        public string WorkPlaceLocation { get; set; }
        public string WorkPlaceNote { get; set; }
        public string FullName { get; set; }
        public string ContactName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public long GlobalId { get; set; }
    }

}