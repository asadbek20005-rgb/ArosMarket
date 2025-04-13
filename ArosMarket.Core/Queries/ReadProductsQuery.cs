using ArosMarket.Core.Dtos;
using MediatR;

namespace ArosMarket.Core.Queries;

public class ReadProductsQuery : IRequest<List<ProductDto>>
{

}
