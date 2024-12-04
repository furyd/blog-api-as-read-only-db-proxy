using JsonSqlExample.Api.Settings.Interfaces;

namespace JsonSqlExample.Api.Settings.Implementation;

public class DatabaseSettings : IConnectionString
{
    public string ConnectionString { get; set; } = string.Empty;
}