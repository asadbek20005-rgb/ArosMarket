using ArosMarket.Core.Domain.Entites.BaseEntity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArosMarket.Core.Domain.Entites;
[Table("order_itmes", Schema = "application")]
public class OrderItem : Auditable
{
    [Key]
    [Column("id")]
    public int Id { get; set; }


    [Required]
    [Column("quantity")]
    public int Quantity { get; set; }


    [Required]
    [Column("product_id")]
    public int ProductId { get; set; }


    [Required]
    [Column("order_id")]
    public int OrderId { get; set; }
}
