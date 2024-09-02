using CSharpFunctionalExtensions;
using Dapper;

using DataViewer.Application.Abstractions.DALHandlers;
using DataViewer.Application.Abstractions.Data;
using DataViewer.Application.Quaries;
using DataViewer.DAL.BaseModels;


namespace DataViewer.DAL.Handlers
{
  public class AllUsersQueryHandler : IQueryHandler<Task<Result>, AllUsersQuery>
  {
    private readonly ISqlConnectionFactory _sqlConnectionFactory;
    private readonly string _sqlQuery =
        """
        SELECT UserSK AS UserSK,
               UserId AS UserId,
               UserName AS UserName,
               UserEmail AS UserEmail,
               AnalyticsUpdatedDate AS AnalyticsUpdatedDate,
               GitHubUserId AS GitHubUserId,
               UserType AS UserType
        FROM Users
        """;

    public AllUsersQueryHandler(ISqlConnectionFactory sqlConnectionFactory)
    {
      _sqlConnectionFactory = sqlConnectionFactory;
    }

    public async Task<Result> Handle(AllUsersQuery query)
    {
      using var connection = _sqlConnectionFactory.Create();

      var usersResponse = await connection.QueryAsync<UserBase>(_sqlQuery);

      return Result.Success(usersResponse);
    }
  }
}
