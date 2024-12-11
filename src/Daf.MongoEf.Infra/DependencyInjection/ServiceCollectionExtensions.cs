using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
namespace Daf.MongoEf.Infra.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddMongoDbEfCore(this IServiceCollection services, IConfiguration configuration)
    {
        var mongoDbSettings = configuration.GetSection("MongoDbSettings").Get<MongoDbSettings>();
        services.Configure<MongoDbSettings>(configuration.GetSection("MongoDbSettings"));

        services.AddDbContext<RestaurantReservationDbContext>(options =>
            options.UseMongoDB(mongoDbSettings.AtlasURI ?? "", mongoDbSettings.DatabaseName ?? ""));
        return services;
    }
}