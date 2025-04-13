using ArosMarket.Core.Commands;
using ArosMarket.Core.Dtos;
using ArosMarket.Core.Models.ProductModels;
using ArosMarket.Core.Queries;
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

    public async Task<List<ProductDto>> GetAll()
    {
        var query = new ReadProductsQuery();
        var products = await _mediator.Send(query);
        if (products is null || products.Count() == 0)
        {
            return new List<ProductDto>();
        }
        return products;
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
