using DataReader.Core.ValueObjects.Project;
using DataReader.Core.ValueObjects.Common;


namespace DataReader.Core.Shells
{
  public record ProjectParam(
    CustomGuid projectSK,
    CustomGuid projectId,
    ProjectName projectName,
    CustomDate analyticsUpdatedDate,
    string projectVisibility
  );
}
