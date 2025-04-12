using System.ComponentModel.DataAnnotations;

namespace ArosMarket.Core.Models.ProductModels;

public class AddProductModel
{
    [Required]
    [StringLength(90)]
    public string FullName { get; set; }

    [Required]
    [StringLength(10)]
    public string ShortName { get; set; }

    [Required]
    [StringLength(5)]
    public string Code { get; set; }


    [Required]
    public decimal Price { get; set; }


    [Required]
    [StringLength(15)]
    public string Brand { get; set; }


    public string? Details { get; set; } = null;

    [Required]
    public int ProductTypeId { get; set; }

    
    [Required]
    public int ProductStatusId { get; set; }
}
