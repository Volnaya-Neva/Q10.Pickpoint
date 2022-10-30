namespace Q10.Pickpoint.Models.JsonModel;

public abstract class JsonType1 : IJsonType
{
    public int Number { get; set; }

    public object CreateModelForDb()
    {
        throw new NotImplementedException();
    }
}