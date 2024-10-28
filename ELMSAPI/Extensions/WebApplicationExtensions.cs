using ELMSAPI.Endpoints;
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

        #region MinimalApi

        app.MapReferencesEndpoints();

        #endregion 

        return app;
    }
}
