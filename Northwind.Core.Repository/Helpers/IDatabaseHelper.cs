using Northwind.Core.Repository.Constants;
using System.Data.SqlClient;

namespace Northwind.Core.Repository.Helpers
{
    public interface IDatabaseHelper
    {
         /// <summary>
        /// 取得與設定 DatabaseConstants
        /// </summary>
        /// <value>The database constants </value>
        IDatabaseConstants DatabaseConstants { get; set; }

        /// <summary>
        /// 取得經過[NorthWind]資料庫連線
        /// </summary>        
        /// <returns>DbConnection</returns>
        SqlConnection GetNORTHWINDConnection();
    }
}