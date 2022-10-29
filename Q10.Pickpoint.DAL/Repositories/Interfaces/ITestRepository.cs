using System.Data;

namespace Q10.Pickpoint.DAL.Repositories;

public interface ITestRepository : IGeneralRepository
{
    void WriteDataSets(DataSet dataSet);
}