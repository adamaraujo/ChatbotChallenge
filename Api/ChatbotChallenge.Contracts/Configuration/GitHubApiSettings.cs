namespace ChatbotChallenge.Contracts.Configuration;

public class GitHubApiSettings
{
    public required string BaseUrl { get; set; }
    public required string AuthToken { get; set; }
    public required string ApiVersion { get; set; }
    public required string Accept { get; set; }
    public required string UserAgent { get; set; }
}