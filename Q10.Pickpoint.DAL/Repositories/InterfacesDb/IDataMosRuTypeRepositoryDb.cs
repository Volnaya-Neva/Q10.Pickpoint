using System.Data;

namespace Q10.Pickpoint.DAL.Repositories.InterfacesDb;

public interface IDataMosRuTypeRepositoryDb
{
    int AddDataMosRuTypeViaTVP(DataSet dtos);
}