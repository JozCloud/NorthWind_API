using Northwind.Core.Repository.Interface;
using Northwind.Core.Repository.DTOs;
using Northwind.Core.Repository.Helpers;
using System;
using System.Data.SqlClient;

namespace Northwind.Core.Repository.Implement
{
    public class ShipperRepository : IShipperRepository
    {
        private readonly IDatabaseHelper DatabaseHelper;
        private readonly IDapperHelper DapperHelper;
        public ShipperRepository(IDatabaseHelper databaseHelper, IDapperHelper dapperHelper)
        {
            this.DatabaseHelper = databaseHelper;
            this.DapperHelper = dapperHelper;
        }

        /// <summary>
        /// 取得 Shipper資料
        /// </summary>
        /// <param name="id">Shipper ID</param>
        /// <returns></returns>
        public Response<Shipper> GetShipperById(int id)
        {
            var result = new Response<Shipper> { IsSuccess = true };

            try
            {
                using (SqlConnection conn = this.DatabaseHelper.GetNORTHWINDConnection())
                {
                    string sqlCommand = @"SELECT ShipperID, CompanyName, Phone FROM Shippers WHERE ShipperID = @id";

                    var shipper = this.DapperHelper.QueryFirstOrDefault<Shipper>
                        (
                            conn, sqlCommand, new { id }
                        );

                    result.Data = shipper;
                }
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.ErrorMessage = ex.Message;
            }

            return result;
        }
    }
}