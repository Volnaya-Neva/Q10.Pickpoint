using System.Data;
using Insight.Database;
using Q10.Pickpoint.DAL.Repositories.InterfacesDb;

namespace Q10.Pickpoint.DAL.Repositories;

public class TestRepository : BaseRepository, ITestRepository
{
    private IDataMosRuTypeRepositoryDb _dataMosRuTypeRepositoryDb;
    public TestRepository()
    {
        _dataMosRuTypeRepositoryDb = Connection.As<IDataMosRuTypeRepositoryDb>();
    }


    public void WriteDataSets(DataSet dtos)
    {
        try
        {
            var g = _dataMosRuTypeRepositoryDb.AddDataMosRuTypeViaTVP(dtos);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            
        }
        
    }
}