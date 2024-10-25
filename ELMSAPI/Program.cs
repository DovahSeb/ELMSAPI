using ELMSAPI.Extensions;
using Serilog;

var builder = WebApplication
.CreateBuilder(args)
.ConfigureApplicationBuilder();

var app = builder
    .Build()
    .ConfigureApplication();

try
{
    Log.Information("ELMS Starting Up");
    app.Run();
}
catch (Exception ex)
{
    Log.Fatal(ex, "ELMS Terminated Unexpectedly");
}
finally
{
    Log.CloseAndFlush();
}

