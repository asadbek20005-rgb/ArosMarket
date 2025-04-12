using ArosMarket.Core.Extensions;
using ArosMarket.Core.Models.ProductModels;
using ArosMarket.Core.ServiceContracts;
using Microsoft.AspNetCore.Mvc;

namespace ArosMarket.Api.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class TestsController(IProductService productService) : ControllerBase
{
    private readonly IProductService _productService = productService;
    [HttpPost]
    public async Task<IActionResult> CreateProduct([FromBody] AddProductModel model)
    {
        await _productService.CreateAsync(model);
        if (_productService.IsValid)
        {
            return Ok(new { message = "Done" });
        }
        _productService.CopyToModelState(ModelState);
        return BadRequest(ModelState);
    }

}
