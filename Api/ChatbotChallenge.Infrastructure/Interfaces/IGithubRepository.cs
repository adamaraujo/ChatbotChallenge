using ChatbotChallenge.Contracts.Models;

namespace ChatbotChallenge.Infrastructure.Interfaces;

public interface IGithubRepository
{
    Task<IEnumerable<GithubRepositoryResponse>> GetRepositoriesAsync(string organization);
}