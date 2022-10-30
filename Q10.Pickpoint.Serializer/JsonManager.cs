using Newtonsoft.Json;

namespace Q10.Pickpoint.Serializer;

public class JsonManager
{
    public T? Deserialize<T>(string json)
    {
        T? model = default;
        try { model = JsonConvert.DeserializeObject<T>(json); }
        catch (Exception e) { Console.WriteLine(e); }
        return model;
    }
}