using Microsoft.AspNetCore.Mvc;
using Jade.Motherboard.Domain.Catalog;
//using Jade.Motherboard.Data;


namespace Jade.Motherboard.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatalogController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetItems()
        {
            var items = new List<Item>()
            {
                new Item("Shirt", "Ohio State shirt.", "Nike", 29.99m),
                new Item("Shorts", "Ohio State shorts.", "Nike", 4499m)
            };
            
            return Ok("hello world.");
        }

    }

}