using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using Shopping.API.Data;
using Shopping.API.Model;

namespace Shopping.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductsController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<ProductsController> _logger;
    private readonly ProductContext _productContext;
    public ProductsController(ILogger<ProductsController> logger, ProductContext productContext)
    {
        _logger = logger;
        _productContext = productContext;
    }

    [HttpGet(Name = "Get")]
    public async Task<IEnumerable<Product>> Get()
    {
        return await _productContext.Products.Find(p => true).ToListAsync();
    }
}