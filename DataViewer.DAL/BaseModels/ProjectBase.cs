namespace DataViewer.DAL.BaseModels
{
  public class ProjectBase
  {
    public Guid ProjectSK { get; set; }
    public Guid? ProjectID { get; set; }
    public string? ProjectName { get; set; }
    public string? AnalyticsUpdatedDate { get; set; }
    public string? ProjectVisibility { get; set; }
  }
}
