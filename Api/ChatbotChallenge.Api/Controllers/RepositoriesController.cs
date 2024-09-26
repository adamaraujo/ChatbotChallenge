using ChatbotChallenge.Application.Interfaces;
using ChatbotChallenge.Contracts.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChatbotChallenge.Api.Controllers;

[Route("/api/v1/[controller]")]
[ApiController]
public class RepositoriesController : Controller
{
    private readonly IRepositoriesService _repositoriesService;

    public RepositoriesController(IRepositoriesService repositoriesService)
    {
        _repositoriesService = repositoriesService;
    }

    [HttpGet("csharp")]
    [ProducesResponseType(typeof(Repository), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseError), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> GetAllCsharpRepositories()
    {
        var result = await _repositoriesService.GetAllCsharpRepositories();
        return Ok(result);
    }
}