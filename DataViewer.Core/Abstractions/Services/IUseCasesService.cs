using DataViewer.Core.Models;


namespace DataViewer.Core.Abstractions.Services
{
  public interface IUseCasesService
  {
    Task<IList<Project>> GetAllProjects();
    Task<IList<User>> GetAllUsers();
    Task<IList<WorkItem>> WorkItemsEstimatePerProject();
    Task<IList<WorkItem>> WorkItemsPerProject();
    Task<IList<WorkItem>> WorkItemsPerUser();
  }
}
