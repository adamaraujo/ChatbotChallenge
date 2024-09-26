using ChatbotChallenge.Contracts.Models;
using RestEase;

namespace ChatbotChallenge.Infrastructure.Interfaces.RestEase;

public interface IGithubClient
{
    [Header("Authorization")]
    string Authorization { get; set; }

    [Header("X-GitHub-Api-Version")]
    string ApiVersion { get; set; }

    [Header("Accept")]
    string Accept { get; set; }

    [Header("User-Agent")]
    string UserAgent { get; set; }

    [Get("orgs/{organization}/repos?sort=created&direction=asc")]
    Task<IEnumerable<GithubRepositoryResponse>> GetRepositoriesAsync([Path] string organization);
}