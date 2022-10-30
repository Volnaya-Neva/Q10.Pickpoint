using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Q10.Pickpoint.Business.Services;
using Q10.Pickpoint.ExcelInterop.Tables;
using Q10.Pickpoint.Models.Business;
using Q10.Pickpoint.Models.Controllers.Test.MapObjects;
using Q10.Pickpoint.Models.JsonModel;
using System.ComponentModel;

namespace Q10.Pickpoint.API.Controllers;

public class TestController : BaseController<TestService>
{
    public TestController(IMapper mapper, ITestService testService) : base(mapper, testService)
    {
    }

    [HttpGet("Geo-Json")]
    [Description("Генерация маркеров")]
    public FeatureCollection GetGeoJson([FromQuery] int count = 3) => Service.GetGenFeatureCollection(count);

    [HttpPost("Load-Xlsx-Data-Mos-Ru-Type")]
    [Description("Загрузка типово json файлов из data.mos.ru |Формат таблицы Number/Type/IsUse")]
    public void LoadDataMosRuType([FromBody] string path, TableType type)
    {
        switch (type)
        {
            case TableType.None:
                break;
            case TableType.DataMosRuTypeTable:
                {
                    Service.LoadDataMosRuType<DataMosRuTypeTable>(path);
                    break;
                }
            default:
                throw new ArgumentOutOfRangeException(nameof(type), type, null);
        }
    }

    [HttpPost("Load-Json-Data-Mos-Ru")]
    [Description("Загрузка json файлов из data.mos.ru")]
    public void LoadJsonSource([FromBody] string directory)
    {
        List<IJsonType> jsonTypes = Service.LoadJsonSource(directory);
    }
}