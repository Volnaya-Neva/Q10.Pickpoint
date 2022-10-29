using Q10.Pickpoint.Models.Controllers.Test.MapObjects;

namespace Q10.Pickpoint.Business.Services;

public interface ITestService : IGeneralService
{
    FeatureCollection GetGenFeatureCollection(int count);
    void LoadDataMosRuType(string path);
}