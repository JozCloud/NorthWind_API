using Northwind.Core.Repository.Constants;
using System.Data.SqlClient;

namespace Northwind.Core.Repository.Helpers
{
    public class DatabaseHelper : IDatabaseHelper
    {
        public IDatabaseConstants DatabaseConstants { get; set; }

        public DatabaseHelper(IDatabaseConstants databaseConstants)
        {
            this.DatabaseConstants = databaseConstants;
        }

        public SqlConnection GetNORTHWINDConnection()
        {
            SqlConnection conn = new SqlConnection(this.DatabaseConstants.NORTHWINDConnection);
            return conn;
        }
    }
}