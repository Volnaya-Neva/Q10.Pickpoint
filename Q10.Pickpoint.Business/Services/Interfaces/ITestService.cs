using Q10.Pickpoint.Models.Controllers.Test.MapObjects;
using Q10.Pickpoint.Models.JsonModel;

namespace Q10.Pickpoint.Business.Services;

public interface ITestService : IGeneralService
{
    FeatureCollection GetGenFeatureCollection(int count);
    void LoadDataMosRuType(string path);
    List<IJsonType> LoadJsonSource(string directory);
}