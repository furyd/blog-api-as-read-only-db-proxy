using System.Data.Common;

namespace JsonSqlExample.Api.Factories.Interfaces;

public interface IDatabaseConnectionFactory
{
    Task<DbConnection> Create();
}