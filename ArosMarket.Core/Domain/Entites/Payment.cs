using ArosMarket.Core.Domain.Entites.BaseEntity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArosMarket.Core.Domain.Entites;
[Table("payments", Schema = "application")]
public class Payment : Auditable
{

    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Required]
    [Column("currency_id")]
    public int CurrencyId { get; set; }

    [Required]
    [Column("payment_method_id")]
    public int PaymentMethodId { get; set; }

    [Required]
    [Column("payment_status_id")]
    public int PaymentStatusId { get; set; }

    [Required]
    [Column("product_id")]
    public int ProductId { get; set; }
}
