using JsonSqlExample.Api.Features.Orders.Registration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.RegisterOrdersFeatureServices();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.AddOrdersFeature();

app.Run();
