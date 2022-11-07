using Templates.Shared.DomainObjects;

namespace Templates.Shared.Contracts;

public interface IProjectService
{
    Task<List<Project>> GetProjects();
}