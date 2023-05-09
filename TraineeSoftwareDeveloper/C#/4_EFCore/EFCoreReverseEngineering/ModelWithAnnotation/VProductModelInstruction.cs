using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreReverseEngineering.ModelWithAnnotation;

[Keyless]
public partial class VProductModelInstruction
{
    [Column("ProductModelID")]
    public int ProductModelId { get; set; }

    [StringLength(50)]
    public string Name { get; set; } = null!;

    public string? Instructions { get; set; }

    [Column("LocationID")]
    public int? LocationId { get; set; }

    [Column(TypeName = "decimal(9, 4)")]
    public decimal? SetupHours { get; set; }

    [Column(TypeName = "decimal(9, 4)")]
    public decimal? MachineHours { get; set; }

    [Column(TypeName = "decimal(9, 4)")]
    public decimal? LaborHours { get; set; }

    public int? LotSize { get; set; }

    [StringLength(1024)]
    public string? Step { get; set; }

    [Column("rowguid")]
    public Guid Rowguid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }
}
