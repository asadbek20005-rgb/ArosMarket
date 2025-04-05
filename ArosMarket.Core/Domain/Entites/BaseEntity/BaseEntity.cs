using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArosMarket.Core.Domain.Entites.BaseEntity;

public class BaseEntity
{

    [Key]
    public int Id { get; set; }

    [Required]
    [Column("full_name")]
    [StringLength(30)]
    public string FullName { get; set; }

    [Required]
    [Column("short_name")]
    [StringLength(10)]
    public string ShortName { get; set; }

    [Required]
    [Column("code")]
    [StringLength(5)]
    public string Code { get; set; }
    [Column("created_date")]
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    [Column("created_date")]
    public DateTime UpdatedDate { get; set; }
}
