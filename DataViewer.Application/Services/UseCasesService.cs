using CSharpFunctionalExtensions;

using DataViewer.Core.Models;
using DataViewer.Application.Quaries;
using DataViewer.Application.Abstractions.Services;
using DataViewer.Application.Abstractions.DALHandlers;


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
      throw new NotImplementedException();
    }

    public async Task<IList<Project>> GetAllProjects()
    {
      throw new NotImplementedException();
    }

    public async Task<IList<WorkItem>> WorkItemsPerProject()
    {
      throw new NotImplementedException();
    }

    public async Task<IList<WorkItem>> WorkItemsEstimatePerProject()
    {
      throw new NotImplementedException();
    }

    public async Task<IList<WorkItem>> WorkItemsPerUser()
    {
      throw new NotImplementedException();
    }
  }
}
