using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreReverseEngineering.ModelWithAnnotation;

/// <summary>
/// Cross-reference table mapping sales orders to sales reason codes.
/// </summary>
[PrimaryKey("SalesOrderId", "SalesReasonId")]
[Table("SalesOrderHeaderSalesReason", Schema = "Sales")]
public partial class SalesOrderHeaderSalesReason
{
    /// <summary>
    /// Primary key. Foreign key to SalesOrderHeader.SalesOrderID.
    /// </summary>
    [Key]
    [Column("SalesOrderID")]
    public int SalesOrderId { get; set; }

    /// <summary>
    /// Primary key. Foreign key to SalesReason.SalesReasonID.
    /// </summary>
    [Key]
    [Column("SalesReasonID")]
    public int SalesReasonId { get; set; }

    /// <summary>
    /// Date and time the record was last updated.
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }

    [ForeignKey("SalesOrderId")]
    [InverseProperty("SalesOrderHeaderSalesReasons")]
    public virtual SalesOrderHeader SalesOrder { get; set; } = null!;

    [ForeignKey("SalesReasonId")]
    [InverseProperty("SalesOrderHeaderSalesReasons")]
    public virtual SalesReason SalesReason { get; set; } = null!;
}
