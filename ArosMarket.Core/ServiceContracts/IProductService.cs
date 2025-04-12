using ArosMarket.Core.Dtos;
using ArosMarket.Core.Models.ProductModels;
using StatusGeneric;

namespace ArosMarket.Core.ServiceContracts;

public interface IProductService : IStatusGeneric
{
    Task<List<ProductDto>> GetAll();
    Task<ProductDto> GetById(int id);
    Task CreateAsync(AddProductModel model);
    Task Update(int id, UpdateProductModel model);
    Task Delete(int id);
}
