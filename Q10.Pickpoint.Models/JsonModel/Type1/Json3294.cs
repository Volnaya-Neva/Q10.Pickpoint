namespace Q10.Pickpoint.Models.JsonModel.Type1;

public class Json3294 : JsonType1
{
    public class Properties
    {
        public string Name { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string DocNumber { get; set; }
        public string DocDate { get; set; }
        public Link Link { get; set; }
        public string GlobalId { get; set; }
    }

    public class Link
    {
        public string GlobalId { get; set; }
        public string Value { get; set; }
    }

}