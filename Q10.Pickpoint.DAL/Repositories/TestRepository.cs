using System.Data;
using Insight.Database;
using Microsoft.Data.SqlClient;
using Q10.Pickpoint.DAL.Repositories.InterfacesDb;

namespace Q10.Pickpoint.DAL.Repositories;

public class TestRepository : BaseRepository, ITestRepository
{
    private readonly IDataMosRuTypeRepositoryDb _dataMosRuTypeRepositoryDb;
    public TestRepository() => _dataMosRuTypeRepositoryDb = Connection.As<IDataMosRuTypeRepositoryDb>();

    public void WriteDataSets(DataSet dataSet)
    {
        try
        {
            foreach (DataTable table in dataSet.Tables)
            {
                Connection.OpenConnection();
                SqlCommand cmd = new("AddDataMosRuTypeViaTVP", Connection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParam = cmd.Parameters.AddWithValue("@Dtos", table);
                sqlParam.SqlDbType = SqlDbType.Structured;
                cmd.ExecuteNonQuery();
                Connection.Close();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }

    public bool CheckIsUseByNumber(int number)
    {
        bool isUse;
        try
        {
            isUse = _dataMosRuTypeRepositoryDb.CheckIsUseByNumber(number);
        }
        catch (Exception e)
        {
            isUse = false;
            Console.WriteLine($"Ошибка проверки {e.Message}");
        }

        return isUse;
    }
}