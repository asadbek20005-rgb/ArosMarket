using ArosMarket.Core.Domain.RepositoryContracts;
using ArosMarket.Core.Dtos;
using ArosMarket.Core.Queries;
using Mapster;
using MediatR;

namespace ArosMarket.Core.Handlers;

public class ReadProductsHandler(IUnitOfWork unitOfWork) : IRequestHandler<ReadProductsQuery, List<ProductDto>>
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    public async Task<List<ProductDto>> Handle(ReadProductsQuery request, CancellationToken cancellationToken)
    {
        var products = await _unitOfWork.ProductRepository.GetAllAsync();
        var productDtos = products.Adapt<List<ProductDto>>();
        return productDtos;
    }
}
