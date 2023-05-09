using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreReverseEngineering.ModelWithAnnotation;

/// <summary>
/// Cross-reference table mapping products to special offer discounts.
/// </summary>
[PrimaryKey("SpecialOfferId", "ProductId")]
[Table("SpecialOfferProduct", Schema = "Sales")]
[Index("Rowguid", Name = "AK_SpecialOfferProduct_rowguid", IsUnique = true)]
[Index("ProductId", Name = "IX_SpecialOfferProduct_ProductID")]
public partial class SpecialOfferProduct
{
    /// <summary>
    /// Primary key for SpecialOfferProduct records.
    /// </summary>
    [Key]
    [Column("SpecialOfferID")]
    public int SpecialOfferId { get; set; }

    /// <summary>
    /// Product identification number. Foreign key to Product.ProductID.
    /// </summary>
    [Key]
    [Column("ProductID")]
    public int ProductId { get; set; }

    /// <summary>
    /// ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
    /// </summary>
    [Column("rowguid")]
    public Guid Rowguid { get; set; }

    /// <summary>
    /// Date and time the record was last updated.
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("SpecialOfferProducts")]
    public virtual Product Product { get; set; } = null!;

    [InverseProperty("SpecialOfferProduct")]
    public virtual ICollection<SalesOrderDetail> SalesOrderDetails { get; set; } = new List<SalesOrderDetail>();

    [ForeignKey("SpecialOfferId")]
    [InverseProperty("SpecialOfferProducts")]
    public virtual SpecialOffer SpecialOffer { get; set; } = null!;
}
