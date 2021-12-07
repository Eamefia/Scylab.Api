using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Scylap.Data.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scylab.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : Controller
    {
        private readonly IItemService itemService;
        public ItemsController(IItemService itemService)
        {
            this.itemService = itemService;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllItemsAsync()
        {
            try
            {
                return Ok(await itemService.GetAllItemsAsync());
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data");
            }
            
        }
    }
}
