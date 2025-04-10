namespace ArosMarket.Core.Models.ProductModels;

public class UpdateProductModel
{

    public string? FullName { get; set; } = null;

    public string? ShortName { get; set; }

    public string? Code { get; set; }

    public decimal Price { get; set; }

    public string? Brand { get; set; }
    public string? Details { get; set; } = null;
    public int ProductTypeId { get; set; }
    public int ProductStatusId { get; set; }
}
