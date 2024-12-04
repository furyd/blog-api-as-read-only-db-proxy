using JsonSqlExample.Api.Factories.Interfaces;
using JsonSqlExample.Api.Settings.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using System.Data.Common;

namespace JsonSqlExample.Api.Factories.Implementation;

public class SqlServerDatabaseConnectionFactory<TSettings>(IOptions<TSettings> settings)
    : IDatabaseConnectionFactory
    where TSettings : class, IConnectionString
{
    public async Task<DbConnection> Create()
    {
        var connection = new SqlConnection(settings.Value.ConnectionString);
        await connection.OpenAsync();
        return connection;
    }
}