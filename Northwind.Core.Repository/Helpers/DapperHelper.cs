using Dapper;
using System.Data;

namespace Northwind.Core.Repository.Helpers
{
    public class DapperHelper : IDapperHelper
    {
        public T QueryFirstOrDefault<T>(IDbConnection conn, string sql, object para = null)
        {
            return conn.QueryFirstOrDefault<T>(
                    sql,
                    para
                );
        }

        public int Execute(IDbConnection conn, string sql, object para = null)
        {
            return conn.Execute(
                    sql,
                    para
                );
        }
    }
}