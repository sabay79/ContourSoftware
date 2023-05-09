using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreReverseEngineering.ModelWithAnnotation;

/// <summary>
/// Lookup table containing standard ISO currencies.
/// </summary>
[Table("Currency", Schema = "Sales")]
[Index("Name", Name = "AK_Currency_Name", IsUnique = true)]
public partial class Currency
{
    /// <summary>
    /// The ISO code for the Currency.
    /// </summary>
    [Key]
    [StringLength(3)]
    public string CurrencyCode { get; set; } = null!;

    /// <summary>
    /// Currency name.
    /// </summary>
    [StringLength(50)]
    public string Name { get; set; } = null!;

    /// <summary>
    /// Date and time the record was last updated.
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }

    [InverseProperty("CurrencyCodeNavigation")]
    public virtual ICollection<CountryRegionCurrency> CountryRegionCurrencies { get; set; } = new List<CountryRegionCurrency>();

    [InverseProperty("FromCurrencyCodeNavigation")]
    public virtual ICollection<CurrencyRate> CurrencyRateFromCurrencyCodeNavigations { get; set; } = new List<CurrencyRate>();

    [InverseProperty("ToCurrencyCodeNavigation")]
    public virtual ICollection<CurrencyRate> CurrencyRateToCurrencyCodeNavigations { get; set; } = new List<CurrencyRate>();
}
