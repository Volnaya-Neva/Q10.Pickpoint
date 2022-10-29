using Insight.Database.Providers.MsSqlClient;
using Microsoft.Data.SqlClient;
using Q10.Pickpoint.Core;

namespace Q10.Pickpoint.DAL.Repositories;

public abstract class BaseRepository
{
    protected SqlConnection Connection;
    protected BaseRepository()
    {
        Connection = new(Instance.App.Config.DbSettings.ConnectionString);
        SqlInsightDbProvider.RegisterProvider();
    }
}