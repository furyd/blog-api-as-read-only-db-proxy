using Dapper;
using JsonSqlExample.Api.Factories.Interfaces;
using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace JsonSqlExample.Api.Features.Orders.Controllers;

public static class Queries
{
    public static async Task List(
        [FromServices] IDatabaseConnectionFactory factory,
        HttpContext context
        )
    {
        const string sql = """
            SELECT
            		[Id]
            	,	[Name]
            	,	(
            			SELECT
            					[Id]
            				,	[Name]
            			FROM [OrderItems]
            			WHERE	1=1
            			AND		[Order] = [Orders].[RowId]
            			FOR JSON PATH
            		) AS [Items]
            FROM [Orders]
            WHERE 1=1
            FOR JSON PATH
            """;

        var watch = System.Diagnostics.Stopwatch.StartNew();
        watch.Start();

        await using var connection = await factory.Create();

        var results = await connection.QueryAsync<string>(sql);

        context.Response.ContentType = System.Net.Mime.MediaTypeNames.Application.Json;

        foreach (var result in results)
        {
            await context.Response.BodyWriter.WriteAsync(Encoding.UTF8.GetBytes(result));
        }

        watch.Stop();
        Console.WriteLine($"Elapsed: {watch.ElapsedMilliseconds}ms");
    }
}