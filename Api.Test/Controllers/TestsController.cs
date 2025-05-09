﻿using ArosMarket.Core.Extensions;
using ArosMarket.Core.Models.ProductModels;
using ArosMarket.Core.ServiceContracts;
using Microsoft.AspNetCore.Mvc;

namespace Api.Test.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class TestsController(IProductService productService) : ControllerBase
{
    private readonly IProductService _productService = productService;

    [HttpPost]
    public async Task<IActionResult> CreateProduct(AddProductModel model)
    {
        await _productService.CreateAsync(model);
        if (_productService.IsValid)
            return Ok(new { message = "Product created successfully." });

        _productService.CopyToModelState(ModelState);
        return BadRequest(ModelState);
    }
}
