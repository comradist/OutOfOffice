
using OutOfOffice.Application.Interfaces;
using OutOfOffice.Domain.Models.Entities;

namespace OutOfOffice.Persistence.Repositories;

public class ProjectRepository : GenericRepositoryManager<Project, Guid>, IProjectRepository
{
    public ProjectRepository(RepositoryOutOfOfficeDbContext repositoryOutOfOfficeDbContext) : base(repositoryOutOfOfficeDbContext)
    {
    }
}