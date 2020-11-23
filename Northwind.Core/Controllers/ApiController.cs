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

        public IActionResult Index()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public Response<Shipper> GetShipper(string id)
        {
            int.TryParse(id, out int sid);
            return this.ShipperService.GetShipperById(sid);
        }

        [HttpPost]
        public Response<bool> AddShipper(ShipperData sd)
        {
            return this.ShipperService.AddShipper(sd.name, sd.phone);
        }

        [HttpPut("{id}")]
        public Response<bool> UpdateShipper(string id, ShipperData sd)
        {
            int.TryParse(id, out int sid);
            return this.ShipperService.UpdateShipper(sid, sd.name, sd.phone);
        }

        [HttpDelete("{id}")]
        public Response<bool> DeleteShipper(string id)
        {
            int.TryParse(id, out int sid);
            return this.ShipperService.DeleteShipperById(sid);
        }
    }
}