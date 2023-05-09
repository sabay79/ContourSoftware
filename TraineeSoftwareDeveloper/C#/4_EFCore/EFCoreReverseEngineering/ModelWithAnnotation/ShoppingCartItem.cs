using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreReverseEngineering.ModelWithAnnotation;

/// <summary>
/// Contains online customer orders until the order is submitted or cancelled.
/// </summary>
[Table("ShoppingCartItem", Schema = "Sales")]
[Index("ShoppingCartId", "ProductId", Name = "IX_ShoppingCartItem_ShoppingCartID_ProductID")]
public partial class ShoppingCartItem
{
    /// <summary>
    /// Primary key for ShoppingCartItem records.
    /// </summary>
    [Key]
    [Column("ShoppingCartItemID")]
    public int ShoppingCartItemId { get; set; }

    /// <summary>
    /// Shopping cart identification number.
    /// </summary>
    [Column("ShoppingCartID")]
    [StringLength(50)]
    public string ShoppingCartId { get; set; } = null!;

    /// <summary>
    /// Product quantity ordered.
    /// </summary>
    public int Quantity { get; set; }

    /// <summary>
    /// Product ordered. Foreign key to Product.ProductID.
    /// </summary>
    [Column("ProductID")]
    public int ProductId { get; set; }

    /// <summary>
    /// Date the time the record was created.
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime DateCreated { get; set; }

    /// <summary>
    /// Date and time the record was last updated.
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("ShoppingCartItems")]
    public virtual Product Product { get; set; } = null!;
}
