using ELMSAPI.Endpoints;
using Microsoft.AspNetCore.Identity;
using Serilog;
using System.Globalization;

namespace ELMSAPI.Extensions;

public static class WebApplicationExtensions
{
    public static WebApplication ConfigureApplication(this WebApplication app)
    {
        #region Logger

        app.UseSerilogRequestLogging();

        #endregion

        #region API Configuration

        app.UseHttpsRedirection();

        #endregion

        #region Swagger

        var textInfo = CultureInfo.CurrentCulture.TextInfo;

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            c.SwaggerEndpoint(
                "/swagger/v1/swagger.json",
                $"ELMS API - {textInfo.ToTitleCase(app.Environment.EnvironmentName)} - V1"));
        }

        #endregion

        #region Exception Handling

        app.UseExceptionHandler();

        #endregion

        #region Authorization Policy

        app.UseAuthorization();

        #endregion

        #region MinimalApi

        app.MapReferencesEndpoints();
        app.MapIdentityApi<IdentityUser>();

        #endregion 

        return app;
    }
}
