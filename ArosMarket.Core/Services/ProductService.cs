using ArosMarket.Core.Domain.Entites;
using ArosMarket.Core.Domain.RepositoryContracts;
using ArosMarket.Core.Dtos;
using ArosMarket.Core.Models.ProductModels;
using ArosMarket.Core.ServiceContracts;
using FluentValidation;
using Mapster;
using StatusGeneric;

namespace ArosMarket.Core.Services;

public class ProductService(IUnitOfWork unitOfWork, IValidator<AddProductModel> validator) : StatusGenericHandler, IProductService
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IValidator<AddProductModel> _validator = validator;
    public async Task CreateAsync(AddProductModel model)
    {
        await using var transaction = await _unitOfWork.BeginTransactionAsync();

        try
        {
            var validationResult = await _validator.ValidateAsync(model);
            if (!validationResult.IsValid)
            {
                foreach (var error in validationResult.Errors)
                {
                    AddError(error.ErrorMessage);
                }
                return;
            }
            var productType = await _unitOfWork.ProductTypeRepository.GetByIdAsync(model.ProductTypeId);
            if (productType is null)
            {
                AddError($"ProductType with id {model.ProductTypeId} not found.");
                return;
            }

            var productStatus = await _unitOfWork.ProductStatusRepository.GetByIdAsync(model.ProductStatusId);
            if (productStatus is null)
            {
                AddError($"ProductStatus with id {model.ProductStatusId} not found.");
                return;
            }

            var newProduct = model.Adapt<Product>();
            await _unitOfWork.ProductRepository.AddAsync(newProduct);
            await _unitOfWork.ProductRepository.SaveChanges();

            await transaction.CommitAsync();
        }
        catch (Exception ex)
        {
            await transaction.RollbackAsync();
            AddError($"Transaction failed: {ex.Message}");
        }
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
