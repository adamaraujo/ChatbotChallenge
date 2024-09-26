using ChatbotChallenge.Application.Interfaces;
using ChatbotChallenge.Contracts.Models;
using ChatbotChallenge.Infrastructure.Interfaces;

namespace ChatbotChallenge.Application.Services;

public class RepositoriesService : IRepositoriesService
{
    private readonly IGithubRepository _githubRepository;
    private const string ORGANIZATION = "takenet";

    public RepositoriesService(IGithubRepository githubRepository)
    {
        _githubRepository = githubRepository;
    }

    public async Task<IEnumerable<Repository>> GetAllCsharpRepositories()
    {
        var result = await _githubRepository.GetRepositoriesAsync(ORGANIZATION);
        return result
            .Where(repo => repo.language == "C#")
            .Take(5)
            .Select(repo => new Repository
            {
                FullName = repo.full_name,
                Description = repo.description,
                AvatarUrl = repo.owner.avatar_url,
                CreatedAt = repo.created_at
            })
            .ToList();

    }
}