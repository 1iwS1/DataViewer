using CSharpFunctionalExtensions;

using DataReader.Core.Shells;
using DataReader.Core.ValueObjects.Common;


namespace DataReader.Core.Models
{
  public class WorkItem
  {
    private WorkItem(WorkItemParam shell)
    {
      WorkItemId = shell.workItemId;
      InProgressDate = shell.inProgressDate;
      CompletedDate = shell.completedDate;
      InProgressDateSK = shell.inProgressDateSK;
      CompletedDateSK = shell.completedDateSK;
      AnalyticsUpdatedDate = shell.analyticsUpdatedDate;
      ProjectSK = shell.projectSK;
      WorkItemRevisionSK = shell.workItemRevisionSK;
      AreaSK = shell.areaSK;
      IterationSK = shell.iterationSK;
      AssignedToUserSK = shell.assignedToUserSK;
      ChangedByUserSK = shell.changedByUserSK;
      CreatedByUserSK = shell.createdByUserSK;
      ActivatedByUserSK = shell.activatedByUserSK;
      ClosedByUserSK = shell.closedByUserSK;
      ResolvedByUserSK = shell.resolvedByUserSK;
      ActivatedDateSK = shell.activatedDateSK;
      ChangedDateSK = shell.changedDateSK;
      ClosedDateSK = shell.сlosedDateSK;
      CreatedDateSK = shell.createdDateSK;
      ResolvedDateSK = shell.resolvedDateSK;
      StateChangeDateSK = shell.stateChangeDateSK;
      WorkItemType = shell.workItemType;
      ChangedDate = shell.changedDate;
      CreatedDate = shell.createdDate;
      State = shell.state;
      ActivatedDate = shell.activatedDate;
      ClosedDate = shell.closedDate;
      Priority = shell.priority;
      ResolvedDate = shell.resolvedDate;
      CompletedWork = shell.completedWork;
      Effort = shell.effort;
      FinishDate = shell.finishDate;
      OriginalEstimate = shell.originalEstimate;
      RemainingWork = shell.remainingWork;
      StartDate = shell.startDate;
      StoryPoints = shell.storyPoints;
      TargetDate = shell.targetDate;
      ParentWorkItemId = shell.parentWorkItemId;
      TagNames = shell.tagNames;
      StateChangeDate = shell.stateChangeDate;
      Custom_Company = shell.custom_Company;
      Custom_719f69f1__002Df7d0__002D4baa__002Db6ce__002De77ad5dfcdf3 =
        shell.custom_719f69f1__002Df7d0__002D4baa__002Db6ce__002De77ad5dfcdf3;
      Custom_Eksternareferenca = shell.custom_Eksternareferenca;
      Custom_ITServiceorApplication = shell.custom_ITServiceorApplication;
      Custom_TicketNo = shell.custom_TicketNo;
    }

    public int WorkItemId { get; }
    public CustomDate InProgressDate { get; }
    public CustomDate CompletedDate { get; }
    public string? InProgressDateSK { get; }
    public string? CompletedDateSK { get; }
    public CustomDate AnalyticsUpdatedDate { get; }
    public CustomGuid ProjectSK { get; } // foreign key Project
    public int? WorkItemRevisionSK { get; }
    public CustomGuid AreaSK { get; } // понадобятся в будущем
    public CustomGuid IterationSK { get; } // понадобятся в будущем
    public CustomGuid AssignedToUserSK { get; } // foreign key Users
    public CustomGuid ChangedByUserSK { get; } // foreign key Users
    public CustomGuid CreatedByUserSK { get; } // foreign key Users
    public CustomGuid ActivatedByUserSK { get; } // foreign key Users
    public CustomGuid ClosedByUserSK { get; } // foreign key Users
    public CustomGuid ResolvedByUserSK { get; } // foreign key Users
    public string? ActivatedDateSK { get; }
    public string? ChangedDateSK { get; }
    public string? ClosedDateSK { get; }
    public string? CreatedDateSK { get; }
    public string? ResolvedDateSK { get; }
    public string? StateChangeDateSK { get; }
    public string? WorkItemType { get; }
    public CustomDate ChangedDate { get; }
    public CustomDate CreatedDate { get; }
    public string? State { get; }
    public CustomDate ActivatedDate { get; }
    public CustomDate ClosedDate { get; }
    public int? Priority { get; }
    public CustomDate ResolvedDate { get; }
    public double? CompletedWork { get; }
    public string? Effort { get; }
    public CustomDate FinishDate { get; }
    public string? OriginalEstimate { get; }
    public string? RemainingWork { get; }
    public string? StartDate { get; }
    public string? StoryPoints { get; }
    public string? TargetDate { get; }
    public int? ParentWorkItemId { get; }
    public string? TagNames { get; }
    public CustomDate StateChangeDate { get; }
    public string? Custom_719f69f1__002Df7d0__002D4baa__002Db6ce__002De77ad5dfcdf3 { get; }
    public string? Custom_Company { get; }
    public string? Custom_Eksternareferenca { get; }
    public string? Custom_ITServiceorApplication { get; }
    public string? Custom_Statusprojekta { get; }
    public string? Custom_TicketNo { get; }

    public static Result<WorkItem> Create(WorkItemParam shell)
    {
      WorkItem workItem = new WorkItem(shell);

      return Result.Success(workItem);
    }
  }
}
