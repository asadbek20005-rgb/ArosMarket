using ArosMarket.Core.Models.ProductModels;
using FluentValidation;

namespace ArosMarket.Core.Validators;

public class AddProductModelValidator : AbstractValidator<AddProductModel>
{
    public AddProductModelValidator()
    {
        RuleFor(x => x.Price)
            .NotEmpty()
            .WithMessage("Price is required.")
            .GreaterThan(0)
            .WithMessage("Price must be greater than 0.");
        RuleFor(x => x.Brand)
            .NotEmpty()
            .WithMessage("Brand is required.")
            .Length(1, 15)
            .WithMessage("Brand must be between 1 and 15 characters long.");
        RuleFor(x => x.ProductTypeId)
            .NotEmpty()
            .WithMessage("Product Type ID is required.");
        RuleFor(x => x.ProductStatusId)
            .NotEmpty()
            .WithMessage("Product Status ID is required.");
    }
}
