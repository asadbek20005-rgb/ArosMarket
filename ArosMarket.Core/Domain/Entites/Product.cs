using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArosMarket.Core.Domain.Entites;
[Table("product", Schema ="application")]
public class Product : BaseEntity.BaseEntity
{
    [Required]
    [Column("price")]
    public decimal Price { get; set; }


    [Required]
    [Column("brand")]
    [StringLength(15)]
    public string Brand { get; set; }


    [Column("details")]
    public string? Details { get; set; } = null;

    [Required]
    [Column("product_type_id")]
    public int ProductTypeId { get; set; }


    [Required]
    [Column("product_status_id")]
    public int ProductStatusId { get; set; }



    [ForeignKey(nameof(ProductTypeId))]
    public ProductType? ProductType { get; set; }
}
