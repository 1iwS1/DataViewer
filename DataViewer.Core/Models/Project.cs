using CSharpFunctionalExtensions;
using DataViewer.Core.Shells;
using DataViewer.Core.ValueObjects.Common;
using DataViewer.Core.ValueObjects.Project;


namespace DataViewer.Core.Models
{
  public class Project
  {
    private Project(ProjectParam shell)
    {
      ProjectSK = shell.projectSK;
      ProjectID = shell.projectId;
      ProjectName = shell.projectName;
      AnalyticsUpdatedDate = shell.analyticsUpdatedDate;
      ProjectVisibility = shell.projectVisibility;
    }

    public CustomGuid ProjectSK { get; }
    public CustomGuid ProjectID { get; }
    public ProjectName ProjectName { get; }
    public CustomDate AnalyticsUpdatedDate { get; }
    public string ProjectVisibility { get; } = string.Empty;

    public static Result<Project> Create(ProjectParam shell)
    {
      Project project = new Project(shell);

      return Result.Success(project);
    }
  }
}
