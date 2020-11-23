using Microsoft.Extensions.Configuration;

namespace Northwind.Core.Repository.Constants
{
    public class DatabaseConstants : IDatabaseConstants
    {
        private readonly IConfiguration Configuration;

        public DatabaseConstants(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        /// <summary>
        /// 取得 Database [Northwind] 資料庫連線字串
        /// </summary>
        /// <value>The Northwind DB connection.</value>        
        public string NORTHWINDConnection => Configuration["ConnectionStrings:NORTHWIND"];
    }
}