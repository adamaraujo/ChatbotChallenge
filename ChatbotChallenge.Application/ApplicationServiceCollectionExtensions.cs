using Microsoft.Extensions.DependencyInjection;

namespace ChatbotChallenge.Application;

public static class ApplicationServiceCollectionExtensions
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddTransient<IRepositoriesService, RepositoriesService>();
        return services;
    }
}