using DataReader.Core.ValueObjects.User;
using DataReader.Core.ValueObjects.Common;


namespace DataReader.Core.Shells
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
