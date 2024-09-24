using ChatbotChallenge.Contracts.Configuration;
using ChatbotChallenge.Infrastructure.Api.RestEase;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ChatbotChallenge.Infrastructure;

public static class InfrastructureServiceCollectionExtensions
{
    public static IServiceCollection AddGithubApi(this IServiceCollection services, IConfiguration configuration)
    {
        var githubApiSettings = configuration.GetSection("GitHubApi").Get<GitHubApiSettings>();

        services.AddSingleton<IGithubClient>(provider =>
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