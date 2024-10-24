using ELMSAPI.Infrastructure.Extensions;

namespace ELMSAPI.Extensions;

public static class WebApplicationBuilderExtensions
{
    public static WebApplicationBuilder ConfigureApplicationBuilder(this WebApplicationBuilder builder)
    {
        #region Swagger

        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        #endregion

        #region Project Dependencies

        builder.Services.AddInfrastructure(builder.Configuration);

        #endregion

        return builder;
    }
}
