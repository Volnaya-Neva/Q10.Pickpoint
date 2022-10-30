using System.Data;
using Insight.Database;
using Microsoft.Data.SqlClient;
using Q10.Pickpoint.DAL.Repositories.InterfacesDb;

namespace Q10.Pickpoint.DAL.Repositories;

public class TestRepository : BaseRepository, ITestRepository
{
    private IDataMosRuTypeRepositoryDb _dataMosRuTypeRepositoryDb;
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
}