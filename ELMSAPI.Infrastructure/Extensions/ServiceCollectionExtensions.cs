using ELMSAPI.Application.LeaveStatuses;
using ELMSAPI.Application.LeaveTypes;
using ELMSAPI.Infrastructure.Database;
using ELMSAPI.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace ELMSAPI.Infrastructure.Extensions;
public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        var defaultConnectionString = configuration.GetConnectionString("DefaultConnection");

        services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(defaultConnectionString));

        services.AddAutoMapper(Assembly.GetExecutingAssembly());

        services.AddScoped<ILeaveStatusesRepository, LeaveStatusesRepository>();
        services.AddScoped<ILeaveTypesRepository, LeaveTypesRepository>();

        return services;
    }
}
