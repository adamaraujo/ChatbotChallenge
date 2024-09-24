using ChatbotChallenge.Application;
using ChatbotChallenge.Infrastructure.Api.RestEase;
using Microsoft.AspNetCore.Mvc;

namespace ChatbotChallenge.Api.Controllers;

[ApiController]
public class RepositoriesController : Controller
{
    private readonly IRepositoriesService _repositoriesService;

    public RepositoriesController(IRepositoriesService repositoriesService)
    {
        _repositoriesService = repositoriesService;
    }

    [HttpGet("/api/repos")]
    public async Task<IActionResult> GetAll()
    {
        var result = await _repositoriesService.GetAll();
        return Ok(result);
    }
}