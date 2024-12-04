using JsonSqlExample.Api.Factories.Implementation;
using JsonSqlExample.Api.Factories.Interfaces;
using JsonSqlExample.Api.Features.Orders.Constants;
using JsonSqlExample.Api.Features.Orders.Controllers;
using JsonSqlExample.Api.Settings.Implementation;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace JsonSqlExample.Api.Features.Orders.Registration;

public static class ComposeDependencies
{
    public static void RegisterOrdersFeatureServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddOptions();
        builder.Services.Configure<DatabaseSettings>(builder.Configuration.GetSection(nameof(DatabaseSettings)));
        builder.Services.TryAddSingleton<IDatabaseConnectionFactory, SqlServerDatabaseConnectionFactory<DatabaseSettings>>();
    }

    public static void AddOrdersFeature(this WebApplication application)
    {
        application.MapGet(Routes.List, Queries.List);
    }
}