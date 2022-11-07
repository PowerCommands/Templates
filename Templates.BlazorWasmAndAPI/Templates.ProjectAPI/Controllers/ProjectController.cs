using Microsoft.AspNetCore.Mvc;
using Templates.Shared.DomainObjects;

namespace Templates.ProjectAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProjectController : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<Project>> Get()
    {
        return new ActionResult<IEnumerable<Project>>(new List<Project>()
        {
            new Project
            {
                Name = "Alpha",
                Created = DateTime.Now.AddDays(-3),
                IsActive = true,
                ProjectId = Guid.NewGuid()
            }, new Project
            {
                Name = "Beta",
                Created = DateTime.Now.AddDays(-6),
                IsActive = true,
                ProjectId = Guid.NewGuid()
            }
        });
    }
}