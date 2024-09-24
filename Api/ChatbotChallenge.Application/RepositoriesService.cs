using ChatbotChallenge.Contracts;
using ChatbotChallenge.Infrastructure.Api.RestEase;

namespace ChatbotChallenge.Application;

public class RepositoriesService : IRepositoriesService
{
    private readonly IGithubClient _githubClient;
    private const string ORGANIZATION = "takenet";

    public RepositoriesService(IGithubClient githubClient)
    {
        _githubClient = githubClient;
    }

    public async Task<IEnumerable<GithubRepo>> GetAll()
    {
        var result = await _githubClient.GetRepositories(ORGANIZATION);
        return result
            .Where(repo => repo.language == "C#")
            .Take(5)
            .ToList();
    }
}