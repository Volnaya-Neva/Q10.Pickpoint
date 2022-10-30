using Q10.Pickpoint.DAL.Repositories;
using Q10.Pickpoint.ExcelInterop;
using Q10.Pickpoint.ExcelInterop.Tables;
using Q10.Pickpoint.Models.Controllers.Test.MapObjects;
using System.Data;

namespace Q10.Pickpoint.Business.Services;

public class TestService : BaseService<ITestRepository>, ITestService 
{
    public TestService(ITestRepository testRepository) : base(testRepository)
    {
    }

    public FeatureCollection GetGenFeatureCollection(int count)
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

    public void LoadDataMosRuType<T>(string path) where T : BaseTable, new()
    {
        ExcelMaster excelMaster = new();
        List<object[,]> values = excelMaster.ReadExcel(path);
        T table = new();
        excelMaster.ConvertToDataSet(values, ref table);
        DataSet dataSet = table.Fill<T>();
        Repository.WriteDataSets(dataSet);
    }
}