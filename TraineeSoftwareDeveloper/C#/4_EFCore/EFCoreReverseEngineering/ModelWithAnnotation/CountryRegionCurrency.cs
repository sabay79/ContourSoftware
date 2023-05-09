using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreReverseEngineering.ModelWithAnnotation;

/// <summary>
/// Cross-reference table mapping ISO currency codes to a country or region.
/// </summary>
[PrimaryKey("CountryRegionCode", "CurrencyCode")]
[Table("CountryRegionCurrency", Schema = "Sales")]
[Index("CurrencyCode", Name = "IX_CountryRegionCurrency_CurrencyCode")]
public partial class CountryRegionCurrency
{
    /// <summary>
    /// ISO code for countries and regions. Foreign key to CountryRegion.CountryRegionCode.
    /// </summary>
    [Key]
    [StringLength(3)]
    public string CountryRegionCode { get; set; } = null!;

    /// <summary>
    /// ISO standard currency code. Foreign key to Currency.CurrencyCode.
    /// </summary>
    [Key]
    [StringLength(3)]
    public string CurrencyCode { get; set; } = null!;

    /// <summary>
    /// Date and time the record was last updated.
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }

    [ForeignKey("CountryRegionCode")]
    [InverseProperty("CountryRegionCurrencies")]
    public virtual CountryRegion CountryRegionCodeNavigation { get; set; } = null!;

    [ForeignKey("CurrencyCode")]
    [InverseProperty("CountryRegionCurrencies")]
    public virtual Currency CurrencyCodeNavigation { get; set; } = null!;
}
