using ChatbotChallenge.Contracts.Models;
using ChatbotChallenge.Infrastructure.Interfaces;
using ChatbotChallenge.Infrastructure.Interfaces.RestEase;

namespace ChatbotChallenge.Infrastructure.Repositories;

public class GithubRepository : IGithubRepository
{
    private readonly IGithubClient _githubClient;

    public GithubRepository(IGithubClient githubClient)
    {
        _githubClient = githubClient;
    }

    public async Task<IEnumerable<GithubRepositoryResponse>> GetRepositoriesAsync(string organization)
    {
        try
        {
            return await _githubClient.GetRepositoriesAsync(organization);
        }
        catch (Exception ex)
        {
            throw;
        }
    }
}