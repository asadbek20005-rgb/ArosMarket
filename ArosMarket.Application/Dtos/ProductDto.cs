namespace ArosMarket.Core.Dtos;

public class ProductDto : BaseDto
{

    public decimal Price { get; set; }

    public string Brand { get; set; }

    public string? Details { get; set; } = null;


    public int ProductTypeId { get; set; }

    public int ProductStatusId { get; set; }
}
