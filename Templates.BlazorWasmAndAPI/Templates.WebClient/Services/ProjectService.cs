using PainKiller.Drontlog.Shared.Contract.ClientGui;

namespace Templates.WebClient.Client.Services;

public class ProjectService : HttpService, IProjectService
{
    public ProjectService(HttpClient httpClient, NavigationManager navigationManager, IConfiguration configuration) : base(httpClient, navigationManager, configuration) { }
    public async Task<List<Project>> GetProjects() => await Get<List<Project>>($"{Configuration.ProjectApiBaseAddress}/project/");
}