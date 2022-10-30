﻿using Q10.Pickpoint.ExcelInterop.Tables;
using Q10.Pickpoint.Models.Controllers.Test.MapObjects;

namespace Q10.Pickpoint.Business.Services;

public interface ITestService : IGeneralService
{
    FeatureCollection GetGenFeatureCollection(int count);
    void LoadDataMosRuType<T>(string path) where T : BaseTable, new();
}