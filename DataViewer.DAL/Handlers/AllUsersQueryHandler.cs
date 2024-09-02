using CSharpFunctionalExtensions;
using Dapper;

using DataViewer.Application.Abstractions.DALHandlers;
using DataViewer.Application.Abstractions.Data;
using DataViewer.Application.Quaries;
using DataViewer.Core.Models;
using DataViewer.Core.Shells;
using DataViewer.Core.ValueObjects.Common;
using DataViewer.Core.ValueObjects.User;
using DataViewer.DAL.BaseModels;


namespace DataViewer.DAL.Handlers
{
  public class AllUsersQueryHandler : IQueryHandler<Task<Result<List<User>>>, AllUsersQuery>
  {
    private readonly ISqlConnectionFactory _sqlConnectionFactory;
    private readonly string _sqlQuery =
        """
        SELECT *
        FROM Users
        """;

    public AllUsersQueryHandler(ISqlConnectionFactory sqlConnectionFactory)
    {
      _sqlConnectionFactory = sqlConnectionFactory;
    }

    public async Task<Result<List<User>>> Handle(AllUsersQuery query)
    {
      using var connection = _sqlConnectionFactory.Create();
      connection.Open();

      var usersResponse = await connection.QueryAsync<UserBase>(_sqlQuery);

      if (usersResponse == null)
        return Result.Failure<List<User>>("null response");

      List<User> user = MapToUser(usersResponse);
      
      return Result.Success(user);
    }

    private List<User> MapToUser(IEnumerable<UserBase> users)
    {
      var usersModel = new List<User>();

      foreach(var user in users)
      {
        usersModel.Add(
          User.Create(
            new UserParam(
              CustomGuid.Create(user.UserSK.ToString()).Value,
              CustomGuid.Create(user.UserId.ToString()).Value,
              UserName.Create(user.UserName).Value,
              UserEmail.Create(user.UserEmail).Value,
              CustomDate.Create(user.AnalyticsUpdatedDate).Value,
              user.GitHubUserId,
              user.UserType
            )
          ).Value
        );
      }

      return usersModel;
    }
  }
}
