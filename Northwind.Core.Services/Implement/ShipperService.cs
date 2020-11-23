using Northwind.Core.Services.Interface;
using Northwind.Core.Repository.Implement;
using Northwind.Core.Repository.Interface;
using Northwind.Core.Repository.DTOs;

namespace Northwind.Core.Services.Implement
{
    public class ShipperService : IShipperService
    {
        private readonly IShipperRepository ShipperRepository;

        public ShipperService(IShipperRepository shipperRepository)
        {
            this.ShipperRepository = shipperRepository;
        }

        /// <summary>
        /// 取得 Shipper資料
        /// </summary>
        /// <param name="id">Shipper ID</param>
        /// <returns></returns>
        public Response<Shipper> GetShipperById(int id)
        {
            return this.ShipperRepository.GetShipperById(id);
        }

        /// <summary>
        /// 新增 Shipper資料
        /// </summary>
        /// <param name="name">Shipper Name</param>
        /// <param name="phone">Shipper Phone</param>
        /// <returns></returns>
        public Response<bool> AddShipper(string name, string phone)
        {
            return this.ShipperRepository.AddShipper(name, phone);
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
            return this.ShipperRepository.UpdateShipper(id, name, phone);
        }

        /// <summary>
        /// 刪除 Shipper資料
        /// </summary>
        /// <param name="id">Shipper ID</param>
        /// <returns></returns>
        public Response<bool> DeleteShipperById(int id)
        {
            return this.ShipperRepository.DeleteShipperById(id);
        }
    }
}