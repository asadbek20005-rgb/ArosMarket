using ArosMarket.Core.Domain.Entites.BaseEntity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArosMarket.Core.Domain.Entites;
[Table("user", Schema = "application")]
public class User : Auditable
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; } = Guid.NewGuid();

    public FullName FullName { get; set; }

    [Required]
    [Column("phone_number")]
    [StringLength(15)]
    [Phone]
    public string PhoneNumber { get; set; }


    [Required]
    [Column("password_hash")]
    [StringLength(255)]
    public string PasswordHash { get; set; }

    [Required]
    [Column("gender_id")]
    public int GenderId { get; set; }

    [Required]
    [Column("role_id")]
    public int RoleId { get; set; }

    [Required]
    [Column("user_status_id")]
    public int StatusId { get; set; }

}
