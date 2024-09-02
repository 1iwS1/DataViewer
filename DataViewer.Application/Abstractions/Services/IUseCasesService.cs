using CSharpFunctionalExtensions;

using DataViewer.Application.Quaries;
using DataViewer.Core.Models;


namespace DataViewer.Application.Abstractions.Services
{
  public interface IUseCasesService
  {
    Task<IList<Project>> GetAllProjects();
    Task<Result<List<User>>> GetAllUsers(AllUsersQuery query);
    Task<IList<WorkItem>> WorkItemsEstimatePerProject();
    Task<IList<WorkItem>> WorkItemsPerProject();
    Task<IList<WorkItem>> WorkItemsPerUser();
  }
}
