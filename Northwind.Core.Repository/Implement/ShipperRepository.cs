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
    
        /// <summary>
        /// 新增 Shipper資料
        /// </summary>
        /// <param name="name">Shipper Name</param>
        /// <param name="phone">Shipper Phone</param>
        /// <returns></returns>
        public Response<bool> AddShipper(string  name, string phone)
        {
            var result = new Response<bool> { IsSuccess = true };

            try
            {
                using (SqlConnection conn = this.DatabaseHelper.GetNORTHWINDConnection())
                {
                    string sqlCommand = @"INSERT INTO Shippers (CompanyName, Phone) VALUES (@name, @phone);";

                    int num = this.DapperHelper.Execute
                        (
                            conn, sqlCommand, new { name, phone }
                        );

                    if (num == 1)
                        result.Data = true;
                    else
                        result.Data = false;
                }
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.ErrorMessage = ex.Message;
            }

            return result;
        }

        /// <summary>
        /// 更新 Shipper資料
        /// </summary>
        /// <param name="id">Shipper ID</param>
        /// <param name="name">Shipper Name</param>
        /// <param name="phone">Shipper Phone</param>
        /// <returns></returns>
        public Response<bool> UpdateShipper(int id, string name, string phone)
        {
            var result = new Response<bool> { IsSuccess = true };

            try
            {
                using (SqlConnection conn = this.DatabaseHelper.GetNORTHWINDConnection())
                {
                    string sqlCommand = @"UPDATE Shippers SET CompanyName = @name, Phone = @phone WHERE ShipperID = @id;";
                    
                    int num = this.DapperHelper.Execute
                        (
                            conn, sqlCommand, new { id, name, phone }
                        );

                    if (num == 1)
                        result.Data = true;
                    else
                        result.Data = false;
                }
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.ErrorMessage = ex.Message;
            }

            return result;
        }

        /// <summary>
        /// 刪除 Shipper資料
        /// </summary>
        /// <param name="id">Shipper ID</param>
        /// <returns></returns>
        public Response<bool> DeleteShipperById(int id)
        {
            var result = new Response<bool> { IsSuccess = true };

            try
            {
                using (SqlConnection conn = this.DatabaseHelper.GetNORTHWINDConnection())
                {
                    string sqlCommand = @"DELETE FROM Shippers WHERE ShipperID = @id;";

                    int num = this.DapperHelper.Execute
                        (
                            conn, sqlCommand, new { id }
                        );

                    if (num == 1)
                        result.Data = true;
                    else
                        result.Data = false;
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