using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreReverseEngineering.ModelWithAnnotation;

[Keyless]
public partial class VProductAndDescription
{
    [Column("ProductID")]
    public int ProductId { get; set; }

    [StringLength(50)]
    public string Name { get; set; } = null!;

    [StringLength(50)]
    public string ProductModel { get; set; } = null!;

    [Column("CultureID")]
    [StringLength(6)]
    public string CultureId { get; set; } = null!;

    [StringLength(400)]
    public string Description { get; set; } = null!;
}
