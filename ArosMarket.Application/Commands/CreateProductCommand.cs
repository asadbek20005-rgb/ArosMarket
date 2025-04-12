using ArosMarket.Core.Models.ProductModels;
using MediatR;

namespace ArosMarket.Core.Commands;

public class CreateProductCommand : IRequest
{
    public AddProductModel Model { get; set; }
}
