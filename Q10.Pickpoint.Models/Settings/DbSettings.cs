namespace Q10.Pickpoint.Models.Settings;

public class DbSettings
{
    private string _connectionString;
    public string ConnectionString {
        get => _connectionString
                .Replace("{dbSource}", DbSource)
                .Replace("{dbName}", DbName)
                .Replace("{user}", User)
                .Replace("{password}", Password);
        set => _connectionString = value;
    }
    public string DbSource { get; set; }
    public string DbName { get; set; }
    public string User { get; set; }
    public string Password { get; set; }
}