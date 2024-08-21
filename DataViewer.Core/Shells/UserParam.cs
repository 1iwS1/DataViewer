using DataViewer.Core.ValueObjects.Common;
using DataViewer.Core.ValueObjects.User;


namespace DataViewer.Core.Shells
{
  public record UserParam(
    CustomGuid userSK,
    CustomGuid userId,
    UserName userName,
    UserEmail userEmail,
    CustomDate analyticsUpdatedDate,
    string gitHubUserId,
    string userType
  );
}
