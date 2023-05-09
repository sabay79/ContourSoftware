using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreReverseEngineering.ModelWithAnnotation;

/// <summary>
/// Types of addresses stored in the Address table. 
/// </summary>
[Table("AddressType", Schema = "Person")]
[Index("Name", Name = "AK_AddressType_Name", IsUnique = true)]
[Index("Rowguid", Name = "AK_AddressType_rowguid", IsUnique = true)]
public partial class AddressType
{
    /// <summary>
    /// Primary key for AddressType records.
    /// </summary>
    [Key]
    [Column("AddressTypeID")]
    public int AddressTypeId { get; set; }

    /// <summary>
    /// Address type description. For example, Billing, Home, or Shipping.
    /// </summary>
    [StringLength(50)]
    public string Name { get; set; } = null!;

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

    [InverseProperty("AddressType")]
    public virtual ICollection<BusinessEntityAddress> BusinessEntityAddresses { get; set; } = new List<BusinessEntityAddress>();
}
