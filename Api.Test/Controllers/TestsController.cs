using ArosMarket.Core.Domain.Entites;
using ArosMarket.Core.Domain.RepositoryContracts.BaseContracts;
using Microsoft.AspNetCore.Mvc;

namespace Api.Test.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TestsController
    (
    IBaseRepository<ArosMarket.Core.Domain.Entites.Content> contentRepository
    )
    : ControllerBase
{
    private readonly IBaseRepository<ArosMarket.Core.Domain.Entites.Content> _contentRepository = contentRepository;


    //[HttpPost]
    //public async Task<IActionResult> Add([FromForm]IFormFile file)
    //{
        

    //    await _contentRepository.AddAsync(content);
    //    await _contentRepository.SaveChanges();
    //    return Ok(content);
    //}

}
