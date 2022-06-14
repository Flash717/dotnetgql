using GraphQL.Server.Ui.Voyager;
using Microsoft.EntityFrameworkCore;

using todolistgql;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ApiDbContext>(
    options => options
        .UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))
        .LogTo(Console.WriteLine, LogLevel.Information)
        .EnableSensitiveDataLogging()
        .EnableDetailedErrors()
    )
    .AddGraphQLServer()
    .AddQueryType<Query>();

var app = builder.Build();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapGraphQL();
});

app.UseGraphQLVoyager(new VoyagerOptions()
{
    GraphQLEndPoint = "/graphql"
}, "/graphql-voyager");

//app.MapGet("/", () => "Hello World!");

app.Run();
