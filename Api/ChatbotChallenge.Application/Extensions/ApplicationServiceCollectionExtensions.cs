using ChatbotChallenge.Application.Interfaces;
using ChatbotChallenge.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ChatbotChallenge.Application.Extensions;

public static class ApplicationServiceCollectionExtensions
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddTransient<IRepositoriesService, RepositoriesService>();
        return services;
    }
}