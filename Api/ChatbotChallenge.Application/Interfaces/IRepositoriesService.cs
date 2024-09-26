using ChatbotChallenge.Contracts.Models;

namespace ChatbotChallenge.Application.Interfaces;

public interface IRepositoriesService
{
    public Task<IEnumerable<Repository>> GetAllCsharpRepositories();
}