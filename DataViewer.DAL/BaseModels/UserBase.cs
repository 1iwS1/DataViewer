namespace DataViewer.DAL.BaseModels
{
  public class UserBase
  {
    public Guid UserSK { get; set; }
    public Guid? UserId { get; set; }
    public string? UserName { get; set; }
    public string? UserEmail { get; set; }
    public string? AnalyticsUpdatedDate { get; set; }
    public string? GitHubUserId { get; set; }
    public string? UserType { get; set; }
  }
}
