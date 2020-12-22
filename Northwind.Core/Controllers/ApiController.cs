using Microsoft.AspNetCore.Mvc;
using Northwind.Core.Models;
using Northwind.Core.Repository.DTOs;
using Northwind.Core.Services.Interface;

namespace Northwind.Core.Controllers
{
    [ApiController]
    [Route("api/shipper/[action]/")]
    public class ApiController : Controller
    {
        private readonly IShipperService ShipperService;

        public ApiController(IShipperService shipperService)
        {
            this.ShipperService = shipperService;
        }

        
        [ApiExplorerSettings(IgnoreApi = true)]
        public IActionResult Index()
        {
            return Ok();
        }

        /// <summary>
        ///  取得Shipper資料
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <returns></returns>
        [HttpGet("{id}")]
        public Response<Shipper> GetShipper(string id)
        {
            int.TryParse(id, out int sid);
            return this.ShipperService.GetShipperById(sid);
        }

        /// <summary>
        ///  新增Shipper資料
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <returns></returns>
        [HttpPost]
        public Response<bool> AddShipper(ShipperData sd)
        {
            return this.ShipperService.AddShipper(sd.name, sd.phone);
        }

        /// <summary>
        ///  更新Shipper資料
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <returns></returns>
        [HttpPut("{id}")]
        public Response<bool> UpdateShipper(string id, ShipperData sd)
        {
            int.TryParse(id, out int sid);
            return this.ShipperService.UpdateShipper(sid, sd.name, sd.phone);
        }

        /// <summary>
        ///  刪除Shipper資料
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public Response<bool> DeleteShipper(string id)
        {
            int.TryParse(id, out int sid);
            return this.ShipperService.DeleteShipperById(sid);
        }
    }
}