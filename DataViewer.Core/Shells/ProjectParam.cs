using DataViewer.Core.ValueObjects.Common;
using DataViewer.Core.ValueObjects.Project;


namespace DataViewer.Core.Shells
{
  public record ProjectParam(
    CustomGuid projectSK,
    CustomGuid projectId,
    ProjectName projectName,
    CustomDate analyticsUpdatedDate,
    string projectVisibility
  );
}
