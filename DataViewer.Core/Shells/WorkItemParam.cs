using DataReader.Core.ValueObjects.Common;


namespace DataReader.Core.Shells
{
  public record WorkItemParam(
      int workItemId,                     CustomDate inProgressDate,    CustomDate completedDate,
      string? inProgressDateSK,           string? completedDateSK,                CustomDate analyticsUpdatedDate,
      CustomGuid projectSK,           int workItemRevisionSK,                 CustomGuid areaSK,
      CustomGuid iterationSK,         CustomGuid assignedToUserSK,        CustomGuid changedByUserSK,
      CustomGuid createdByUserSK,     CustomGuid activatedByUserSK,       CustomGuid closedByUserSK,
      CustomGuid resolvedByUserSK,    string? activatedDateSK,                string? changedDateSK,
      string? сlosedDateSK,               string? createdDateSK,                  string? resolvedDateSK,
      string? stateChangeDateSK,          string? workItemType,                   CustomDate changedDate,
      CustomDate createdDate,   string? state,                          CustomDate activatedDate,
      CustomDate closedDate,    int priority,                           CustomDate resolvedDate,
      double completedWork,               string? effort,                         CustomDate finishDate,
      string? originalEstimate,           string? remainingWork,                  string? startDate,
      string? storyPoints,                string? targetDate,                     int parentWorkItemId,
      string? tagNames,                   CustomDate stateChangeDate,   string? custom_Company,
      string? custom_719f69f1__002Df7d0__002D4baa__002Db6ce__002De77ad5dfcdf3,
      string? custom_Eksternareferenca,   string? custom_ITServiceorApplication,  string? custom_Statusprojekta,
      string? custom_TicketNo
    );
}
