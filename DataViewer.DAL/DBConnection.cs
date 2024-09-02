using System.Data;
using System.Data.SqlClient;

using DataViewer.Application.Abstractions.Data;


namespace DataViewer.DAL
{
  public class DBConnection : ISqlConnectionFactory
  {
    

    public IDbConnection Create()
    {
      return new SqlConnection("Server=DESKTOP-UCP7EO7;Database=DataAzure;Trusted_Connection=True;TrustServerCertificate=true;");
    }
  }
}
