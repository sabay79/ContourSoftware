using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreReverseEngineering.ModelWithAnnotation;

/// <summary>
/// Lookup table containing the languages in which some AdventureWorks data is stored.
/// </summary>
[Table("Culture", Schema = "Production")]
[Index("Name", Name = "AK_Culture_Name", IsUnique = true)]
public partial class Culture
{
    /// <summary>
    /// Primary key for Culture records.
    /// </summary>
    [Key]
    [Column("CultureID")]
    [StringLength(6)]
    public string CultureId { get; set; } = null!;

    /// <summary>
    /// Culture description.
    /// </summary>
    [StringLength(50)]
    public string Name { get; set; } = null!;

    /// <summary>
    /// Date and time the record was last updated.
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }

    [InverseProperty("Culture")]
    public virtual ICollection<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultures { get; set; } = new List<ProductModelProductDescriptionCulture>();
}
