using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SecureShop.API.Controllers;

[ApiController]
[Route("api/products")]
public class ProductController : ControllerBase
{
    [HttpGet]
    [Authorize]
    public IActionResult GetProducts()
    {
        return Ok(new[]
        {
            "Laptop",
            "Mobile",
            "Headphones"
        });
    }
}