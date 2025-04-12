using ArosMarket.Core.Commands;
using ArosMarket.Core.Dtos;
using ArosMarket.Core.Models.ProductModels;
using ArosMarket.Core.ServiceContracts;
using MediatR;
using StatusGeneric;

namespace ArosMarket.Core.Services;

public class ProductService(IMediator mediator) : StatusGenericHandler, IProductService
{
    private readonly IMediator _mediator = mediator;
    public async Task CreateAsync(AddProductModel model)
    {
        var command = new CreateProductCommand { Model = model };
        await _mediator.Send(command);
    }



    public Task Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<ProductDto>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<ProductDto> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task Update(int id, UpdateProductModel model)
    {
        throw new NotImplementedException();
    }
}
