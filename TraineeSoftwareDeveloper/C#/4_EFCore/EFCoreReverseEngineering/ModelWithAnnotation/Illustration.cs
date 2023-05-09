using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreReverseEngineering.ModelWithAnnotation;

/// <summary>
/// Bicycle assembly diagrams.
/// </summary>
[Table("Illustration", Schema = "Production")]
public partial class Illustration
{
    /// <summary>
    /// Primary key for Illustration records.
    /// </summary>
    [Key]
    [Column("IllustrationID")]
    public int IllustrationId { get; set; }

    /// <summary>
    /// Illustrations used in manufacturing instructions. Stored as XML.
    /// </summary>
    [Column(TypeName = "xml")]
    public string? Diagram { get; set; }

    /// <summary>
    /// Date and time the record was last updated.
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }

    [InverseProperty("Illustration")]
    public virtual ICollection<ProductModelIllustration> ProductModelIllustrations { get; set; } = new List<ProductModelIllustration>();
}
