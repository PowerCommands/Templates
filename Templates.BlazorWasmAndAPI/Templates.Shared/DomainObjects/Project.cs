namespace Templates.Shared.DomainObjects;

public class Project
{
    public Guid ProjectId { get; set; }
    public string Name { get; set; } = "";
    public DateTime Created { get; set; }
    public bool IsActive { get; set; }
}