using System.Data;
using Insight.Database;
using Microsoft.Data.SqlClient;
using Microsoft.Data.SqlClient.Server;
using Q10.Pickpoint.DAL.Repositories.InterfacesDb;
using Q10.Pickpoint.Models;

namespace Q10.Pickpoint.DAL.Repositories;

public class TestRepository : BaseRepository, ITestRepository
{
    private readonly IDataMosRuTypeRepositoryDb _dataMosRuTypeRepositoryDb;
    public TestRepository() => _dataMosRuTypeRepositoryDb = Connection.As<IDataMosRuTypeRepositoryDb>();

    public void WriteDataSets(string tvpName, DataSet dataSet)
    {
        try
        {
            foreach (DataTable table in dataSet.Tables)
            {
                Connection.OpenConnection();
                SqlCommand cmd = new(tvpName, Connection);
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
    
    public IList<Coordinates> GetCoordinates()
    {
        var list = new List<Coordinates>();

        try
        {
            using (var cmd = new SqlCommand("GetCoordinates", Connection.OpenConnection()))
            {
                using (IDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        list.Add(new Coordinates
                        {
                            Id = Convert.ToInt32(dr[0].ToString()),
                            GlobalId = dr[1].ToString(),
                            Float_0 = Convert.ToDouble(dr[2].ToString()),
                            Float_1 = Convert.ToDouble(dr[3].ToString()),
                        });
                    }
                }
            }

            Connection.Close();
            return list;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }


    public void WriteDataRecords(string tvpName, List<string> nameColumn, List<List<string>> source)
    {
        try
        {
            List<SqlDataRecord>? records = CreateSqlDataRecords(nameColumn, source);
            if (records is null || records.Count is 0 || source.Count is 0)
            {
                return;
            }
            Connection.OpenConnection();
            SqlCommand cmd = new(tvpName, Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sqlParam = cmd.Parameters.AddWithValue("@Dtos", records);
            sqlParam.SqlDbType = SqlDbType.Structured;
            cmd.ExecuteNonQuery();
        }
        catch { /*ignore*/ }
        finally{ Connection.Close(); }
        
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

    private List<SqlDataRecord>? CreateSqlDataRecords(List<string> nameColumn, List<List<string>> source)
    {
        SqlMetaData[] metaData = new SqlMetaData[nameColumn.Count];//Количество полей
        CreateSqlMetaData(nameColumn, ref metaData);
        List<SqlDataRecord> records = new();
        CreateSqlDataRecord(source, metaData, ref records);
        return records;
    }

    private void CreateSqlMetaData(List<string> nameColumn, ref SqlMetaData[] metaData)
    {
        const int maxLength = -1; //Эквивалент MAX
        int index = 0;
        foreach (string column in nameColumn)
        {
            metaData[index++] = new(column, SqlDbType.NVarChar, maxLength);
        }
    }

    private void CreateSqlDataRecord(List<List<string>> source, SqlMetaData[] metaData, ref List<SqlDataRecord> records)
    {
        foreach (List<string> values in source)
        {
            SqlDataRecord record = new(metaData);
            int index = 0;
            foreach (string value in values)
            {
                record.SetSqlString(index++, value);
            }
            records.Add(record);
        }
    }
}