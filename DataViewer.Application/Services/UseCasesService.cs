using CSharpFunctionalExtensions;

using DataViewer.Application.Quaries;
using DataViewer.Core.Abstractions.Services;
using DataViewer.Core.Abstractions.DALHandlers;
using DataViewer.Core.Models;


namespace DataViewer.Application.Services
{
  public class UseCasesService : IUseCasesService
  {
    private readonly IQueryHandler<Result<IList<User>>, AllUsersQuery> _getAllUsersQuery;

    public UseCasesService(IQueryHandler<Result<IList<User>>, AllUsersQuery> getAllUsersQuery)
    {
      _getAllUsersQuery = getAllUsersQuery;
    }

    public async Task<IList<User>> GetAllUsers()
    {

    }

    public async Task<IList<Project>> GetAllProjects()
    {

    }

    public async Task<IList<WorkItem>> WorkItemsPerProject()
    {

    }

    public async Task<IList<WorkItem>> WorkItemsEstimatePerProject()
    {

    }

    public async Task<IList<WorkItem>> WorkItemsPerUser()
    {

    }
  }
}
