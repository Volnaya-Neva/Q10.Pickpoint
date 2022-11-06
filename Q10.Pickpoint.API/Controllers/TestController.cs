using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Q10.Pickpoint.Business.Services;
using Q10.Pickpoint.ExcelInterop.Tables;
using Q10.Pickpoint.Models.Business;
using Q10.Pickpoint.Models.Controllers.Test.MapObjects;
using Q10.Pickpoint.Models.JsonModel;
using System.ComponentModel;
using System.Text;

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
        List<JsonDbModel> baseModel = new();
        foreach (var jsonType in jsonTypes)
        {
            try
            {
                JsonDbModel j = Mapper.Map<JsonDbModel>(jsonType);
                baseModel.Add(j);
            }
            catch (Exception e)
            {
                baseModel = new();
            }
        }

        Service.WriteDbJsons(baseModel);
    }

    [HttpGet("load-csv")]
    [Description("conver data's models to csv file")]
    public IActionResult LoadCsv()
    {
        var builder = new StringBuilder();
        var coordinates = Service.GetCoordinates();
        
        foreach (var c in coordinates)
        {
            foreach (var property in c.GetType().GetProperties())
            {
                builder.Append(property.GetValue(c, null)?.ToString() + ',');
            }
 
            builder.Append("\r\n");
        }        

        return File(Encoding.UTF8.GetBytes(builder.ToString()), "text/csv", "Data.csv");
    }
}