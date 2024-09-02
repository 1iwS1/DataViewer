using System.Data;


namespace DataViewer.Application.Abstractions.Data
{
  public interface ISqlConnectionFactory
  {
    IDbConnection Create();
  }
}
