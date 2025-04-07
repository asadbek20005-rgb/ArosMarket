using ArosMarket.Core.Domain.Entites.BaseEntity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArosMarket.Core.Domain.Entites;
[Table("content", Schema = "application")]
public class Content : Auditable
{
    [Key]
    [Column("id")]
    public int Id { get; set; }


    [Column("name")]
    [StringLength(10)]
    public string? Name { get; set; } = null;


    [Required]
    [Column("file_url")]
    [StringLength(255)]
    public string FileUrl { get; set; }


    [Required]
    [Column("content_type_id")]
    public int ContentTypeId { get; set; }

}
