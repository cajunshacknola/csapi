using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Square.Connect.Api;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var locationsApi = new LocationsApi();
            var locations = locationsApi.ListLocations();
            return new JsonResult(locations);
        }
    }
}