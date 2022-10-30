using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Q10.Pickpoint.Business.Services;
using Q10.Pickpoint.Models.Controllers.Test.MapObjects;
using System.ComponentModel;
using Q10.Pickpoint.ExcelInterop.Tables;
using Q10.Pickpoint.Business.Enums;

namespace Q10.Pickpoint.API.Controllers;

public class TestController : BaseController<TestService>
{
    public TestController(IMapper mapper, ITestService testService) : base(mapper, testService)
    {
    }

    [HttpGet("Geo-Json")]
    [Description("Генерация маркеров")]
    public FeatureCollection GetGeoJson([FromQuery] int count = 3) => Service.GetGenFeatureCollection(count);

    [HttpPost("Load-Data-Mos-Ru-Type")]
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

    [HttpGet("Json")]
    public void G()
    {

    }
}