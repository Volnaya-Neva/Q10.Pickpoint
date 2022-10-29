using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Q10.Pickpoint.Business.Services;
using Q10.Pickpoint.Models.Controllers.Test.MapObjects;
using System.ComponentModel;

namespace Q10.Pickpoint.API.Controllers;

public class TestController : BaseController
{
    public TestController(IMapper mapper, ITestService baseService) : base(mapper, baseService)
    {
    }

    [HttpGet("Geo-Json")]
    [Description("Генерация маркеров")]
    public FeatureCollection GetGeoJson([FromQuery] int count = 3)
    {
        FeatureCollection featureCollection = new()
        {
            Type = nameof(FeatureCollection),
            Features = new Feature[count]
        };
        Random random = new();
        for (int i = 0; i < count; i++)
        {
            featureCollection.Features[i] = new()
            {
                Type = "Feature",
                Geometry = new()
                {
                    Type = "Point",
                    Coordinates = new[] { (float)(37 + random.NextDouble()), (float)(55 + random.NextDouble()) }
                },
                Properties = new()
                {
                    Id = $"{i}",
                    Title = $"{i}"
                }
            };
        }

        return featureCollection;
    }
}