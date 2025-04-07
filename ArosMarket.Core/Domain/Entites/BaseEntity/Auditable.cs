using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArosMarket.Core.Domain.Entites.BaseEntity;

public class Auditable
{
    [Column("created_date")]
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    [Column("created_date")]
    public DateTime UpdatedDate { get; set; }
}
