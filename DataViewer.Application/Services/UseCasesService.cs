using CSharpFunctionalExtensions;

using DataViewer.Core.Models;
using DataViewer.Application.Quaries;
using DataViewer.Application.Abstractions.Services;
using DataViewer.Application.Abstractions.DALHandlers;


namespace DataViewer.Application.Services
{
  public class UseCasesService : IUseCasesService
  {
    private readonly IQueryHandler<Task<Result<List<User>>>, AllUsersQuery> _getAllUsersQuery;

    public UseCasesService(IQueryHandler<Task<Result<List<User>>>, AllUsersQuery> getAllUsersQuery)
    {
      _getAllUsersQuery = getAllUsersQuery;
    }

    public async Task<Result<List<User>>> GetAllUsers(AllUsersQuery query)
    {
      return await _getAllUsersQuery.Handle(query);
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
