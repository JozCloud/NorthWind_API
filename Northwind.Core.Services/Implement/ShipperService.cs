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
    }
}