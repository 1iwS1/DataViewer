using CSharpFunctionalExtensions;

using DataViewer.Application.Abstractions.DALHandlers;
using DataViewer.Application.Abstractions.Data;
using DataViewer.Application.Abstractions.Services;
using DataViewer.Application.Quaries;
using DataViewer.Application.Services;
using DataViewer.Core.Models;
using DataViewer.DAL;
using DataViewer.DAL.Handlers;


public class Program
{
  public static async Task Main(string[] args)
  {

    ISqlConnectionFactory _sqlConnectionFactory = new DBConnection();
    IQueryHandler<Task<Result<List<User>>>, AllUsersQuery> _getAllUsersQuery = new AllUsersQueryHandler(_sqlConnectionFactory);
    IUseCasesService useCasesService = new UseCasesService(_getAllUsersQuery);

    AllUsersQuery query = new();
    await useCasesService.GetAllUsers(query);

  }
}

