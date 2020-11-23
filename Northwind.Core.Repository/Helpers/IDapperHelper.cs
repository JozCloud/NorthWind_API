using System.Data;

namespace Northwind.Core.Repository.Helpers
{
    public interface IDapperHelper
    {
         T QueryFirstOrDefault<T>(IDbConnection conn, string sql, object para = null);
    }
}