using Microsoft.AspNetCore.Mvc;
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
    }
}