namespace DataViewer.Core.Abstractions.DALHandlers
{
  public interface ICommandHandler<TResult, TCommand>
  {
    TResult Handle(TCommand command);
  }
}
