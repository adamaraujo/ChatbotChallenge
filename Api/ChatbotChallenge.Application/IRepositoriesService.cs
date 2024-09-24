using ChatbotChallenge.Contracts;

namespace ChatbotChallenge.Application;

public interface IRepositoriesService
{
    public Task<IEnumerable<GithubRepo>> GetAll();
}