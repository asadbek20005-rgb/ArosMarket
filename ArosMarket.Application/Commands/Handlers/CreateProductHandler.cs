using ArosMarket.Core.Domain.Entites;
using ArosMarket.Core.Domain.RepositoryContracts;
using ArosMarket.Core.Models.ProductModels;
using FluentValidation;
using Mapster;
using MediatR;
using StatusGeneric;

namespace ArosMarket.Core.Commands.Handlers;

public class CreateProductHandler(IUnitOfWork unitOfWork, IValidator<AddProductModel> validator) : StatusGenericHandler, IRequestHandler<CreateProductCommand>
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IValidator<AddProductModel> _validator = validator;

    public async Task<Unit> Handle(CreateProductCommand command, CancellationToken cancellationToken)
    {
        await using var transaction = await _unitOfWork.BeginTransactionAsync();

        try
        {
            var validationResult = await _validator.ValidateAsync(command.Model);
            if (!validationResult.IsValid)
            {
                foreach (var error in validationResult.Errors)
                {
                    AddError(error.ErrorMessage);
                }
                return Unit.Value; 
            }
            var productType = await _unitOfWork.ProductTypeRepository.GetByIdAsync(command.Model.ProductTypeId);
            if (productType is null)
            {
                AddError($"ProductType with id {command.Model.ProductTypeId} not found.");
                return Unit.Value;
            }

            var productStatus = await _unitOfWork.ProductStatusRepository.GetByIdAsync(command.Model.ProductStatusId);
            if (productStatus is null)
            {
                AddError($"ProductStatus with id {command.Model.ProductStatusId} not found.");
                return Unit.Value;
            }

            var newProduct = command.Model.Adapt<Product>();
            await _unitOfWork.ProductRepository.AddAsync(newProduct);
            await _unitOfWork.ProductRepository.SaveChanges();

            await transaction.CommitAsync();
        }
        catch (Exception ex)
        {
            await transaction.RollbackAsync();
            AddError($"Transaction failed: {ex.Message}");
        }

        return Unit.Value;
    }

 
}
