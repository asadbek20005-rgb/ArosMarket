using ArosMarket.Core.Domain.Entites.BaseEntity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArosMarket.Core.Domain.Entites;
[Table("order", Schema = "application")]
public class Order : Auditable
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Required]
    [Column("total_amount")]
    public decimal TotalAmount { get; set; }

    [Required]
    [Column("user_id")]
    public Guid UserId { get; set; }
}