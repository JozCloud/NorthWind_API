using Northwind.Core.Repository.DTOs;

namespace Northwind.Core.Repository.Interface
{
    public interface IShipperRepository
    {
        /// <summary>
        /// 取得 Shipper資料
        /// </summary>
        /// <param name="id">Shipper ID</param>
        /// <returns></returns>
        Response<Shipper> GetShipperById(int id);
    }
}