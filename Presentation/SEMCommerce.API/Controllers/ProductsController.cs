using Microsoft.AspNetCore.Mvc;
using SEMCommerce.Application.Abstractions;

namespace SEMCommerce.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductsController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var productList = _productService.GetProducts();
        return Ok(productList);
    }
}