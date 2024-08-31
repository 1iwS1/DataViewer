namespace DataViewer.Application.Abstractions.DALHandlers
{
  public interface IQueryHandler<TResult, TQuery>
  {
    TResult Handle(TQuery query);
  }
}
