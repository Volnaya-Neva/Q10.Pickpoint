using System.Data;
using Q10.Pickpoint.DAL.Repositories;
using Q10.Pickpoint.ExcelInterop;
using Q10.Pickpoint.ExcelInterop.Tables;
using Q10.Pickpoint.Models.Controllers.Test.MapObjects;

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

    public void LoadDataMosRuType(string path)
    {
        ExcelMaster excelMaster = new();
        List<object[,]> values = excelMaster.ReadExcel(path);
        DataMosRuTypeTable table = new();
        excelMaster.ConvertToDataSet(values, ref table);
        List<DataSet> dataSets = table.Fill();
        dataSets.ForEach(Repository.WriteDataSets);
    }
}