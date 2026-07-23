using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        [Authorize]
        [HttpGet]
        public IActionResult GetProducts()
        {
            List<string> products = new List<string>
            {
                "Laptop",
                "Mouse",
                "Keyboard",
                "Monitor"
            };

            return Ok(products);
        }
    }
}
