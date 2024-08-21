using CSharpFunctionalExtensions;
using DataViewer.Core.Shells;
using DataViewer.Core.ValueObjects.Common;
using DataViewer.Core.ValueObjects.User;


namespace DataViewer.Core.Models
{
  public class User
  {
    private User(UserParam shell)
    {
      UserSK = shell.userSK;
      UserId = shell.userId;
      UserName = shell.userName;
      UserEmail = shell.userEmail;
      AnalyticsUpdatedDate = shell.analyticsUpdatedDate;
      GitHubUserId = shell.gitHubUserId;
      UserType = shell.userType;
    }

    public CustomGuid UserSK { get; }
    public CustomGuid UserId { get; }
    public UserName UserName { get; }
    public UserEmail UserEmail { get; }
    public CustomDate AnalyticsUpdatedDate { get; }
    public string GitHubUserId { get; } = string.Empty;
    public string UserType { get; } = string.Empty;

    public static Result<User> Create(UserParam shell)
    {
      User user = new User(shell);

      return Result.Success(user);
    }
  }
}
