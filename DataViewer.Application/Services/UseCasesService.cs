using CSharpFunctionalExtensions;

using DataViewer.Application.Quaries;
using DataViewer.Core.Abstractions.Services;
using DataViewer.Core.Abstractions.DALHandlers;
using DataViewer.Core.Models;


namespace DataViewer.Application.Services
{
  public class UseCasesService(
    IQueryHandler<Result<IList<User>>, AllUsersQuery> _getAllUsersQuery

    ) : IUseCasesService
  {
    public async Task<IList<User>> GetAllUsers()
    {
      
    }
  }
}
