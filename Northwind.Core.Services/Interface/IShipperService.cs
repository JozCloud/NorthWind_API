using Northwind.Core.Repository.DTOs;

namespace Northwind.Core.Services.Interface
{
    public interface IShipperService
    {
        /// <summary>
        /// 取得 Shipper資料
        /// </summary>
        /// <param name="id">Shipper ID</param>
        /// <returns></returns>
        Response<Shipper> GetShipperById(int id);

        /// <summary>
        /// 新增 Shipper資料
        /// </summary>
        /// <param name="name">Shipper Name</param>
        /// <param name="phone">Shipper Phone</param>
        /// <returns></returns>
        Response<bool> AddShipper(string name, string phone);

        /// <summary>
        /// 更新 Shipper資料
        /// </summary>
        /// <param name="id">Shipper ID</param>
        /// <param name="name">Shipper Name</param>
        /// <param name="phone">Shipper Phone</param>
        /// <returns></returns>
        Response<bool> UpdateShipper(int id, string name, string phone);

        /// <summary>
        /// 刪除 Shipper資料
        /// </summary>
        /// <param name="id">Shipper ID</param>
        /// <returns></returns>
        Response<bool> DeleteShipperById(int id);
    }
}