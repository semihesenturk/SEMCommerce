using Microsoft.Extensions.DependencyInjection;
using SEMCommerce.Application.Abstractions;
using SEMCommerce.Persistence.Concretes;

namespace SEMCommerce.Persistence;

public static class ServiceRegistration
{
    public static void AddPersistenceServices(this IServiceCollection services)
    {
        services.AddSingleton<IProductService, ProductService>();
    }
}