using ChatbotChallenge.Contracts.Configuration;
using ChatbotChallenge.Infrastructure.Interfaces;
using ChatbotChallenge.Infrastructure.Interfaces.RestEase;
using ChatbotChallenge.Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ChatbotChallenge.Infrastructure.Extensions;

public static class InfrastructureServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddGithubApi(configuration);
        services.AddTransient<IGithubRepository, GithubRepository>();

        return services;
    }

    public static IServiceCollection AddGithubApi(this IServiceCollection services, IConfiguration configuration)
    {
        var githubApiSettings = configuration.GetSection("GitHubApi").Get<GitHubApiSettings>();

        services.AddSingleton(provider =>
        {
            var client = RestEase.RestClient.For<IGithubClient>(githubApiSettings!.BaseUrl);
            client.Authorization = githubApiSettings.AuthToken;
            client.ApiVersion = githubApiSettings.ApiVersion;
            client.Accept = githubApiSettings.Accept;
            client.UserAgent = githubApiSettings.UserAgent;

            return client;
        });

        return services;
    }
}