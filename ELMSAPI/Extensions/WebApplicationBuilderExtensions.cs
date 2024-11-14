using ELMSAPI.Application.Extensions;
using ELMSAPI.Domain.Models;
using ELMSAPI.Exceptions;
using ELMSAPI.Infrastructure.Database;
using ELMSAPI.Infrastructure.Extensions;
using Serilog;
using System.Reflection;

namespace ELMSAPI.Extensions;

public static class WebApplicationBuilderExtensions
{
    public static WebApplicationBuilder ConfigureApplicationBuilder(this WebApplicationBuilder builder)
    {
        #region Logger

        builder.Host.UseSerilog((hostContext, loggerConfiguration) =>
        {
            var assembly = Assembly.GetEntryAssembly();

            loggerConfiguration.ReadFrom.Configuration(hostContext.Configuration)
                .Enrich.WithProperty(
                    "Assembly Version",
                    assembly?.GetCustomAttribute<AssemblyFileVersionAttribute>()?.Version)
                .Enrich.WithProperty(
                    "Assembly Informational Version",
                    assembly?.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion);
        });

        #endregion

        #region Swagger

        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        #endregion

        #region Authorization Policy

        builder.Services.AddAuthorization();

        #endregion

        #region Identity Provider

        builder.Services.AddIdentityApiEndpoints<User>(opt =>
        {
            opt.User.RequireUniqueEmail = true;
            opt.Password.RequiredLength = 8;
        })
            .AddEntityFrameworkStores<DatabaseContext>();

        #endregion

        #region Exception Handling

        builder.Services.AddExceptionHandler<GlobalExceptionHandler>();
        builder.Services.AddProblemDetails();

        #endregion

        #region Project Dependencies

        builder.Services.AddInfrastructure(builder.Configuration);
        builder.Services.AddApplication();

        #endregion

        #region Cors

        builder.Services.AddCors(options =>
        {
            var allowedOrigin = builder.Configuration.GetValue<string>("CORSPolicy:AllowedOrigin");

            options.AddDefaultPolicy(x => {
                x.WithOrigins(allowedOrigin);
                x.AllowAnyMethod();
                x.AllowAnyHeader();
                x.AllowCredentials();
            });
        });

        #endregion Cors

        return builder;
    }
}
