using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArosMarket.Core.Domain.Entites.BaseEntity;

public class FullName
{
    [Required]
    [Column("first_name")]
    [StringLength(30)]
    public string FirstName { get; set; }

    [Column("last_name")]
    [StringLength(30)]
    public string? LastName { get; set; } = null;
}
