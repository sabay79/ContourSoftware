using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreReverseEngineering.ModelWithAnnotation;

/// <summary>
/// Lookup table containing the departments within the Adventure Works Cycles company.
/// </summary>
[Table("Department", Schema = "HumanResources")]
[Index("Name", Name = "AK_Department_Name", IsUnique = true)]
public partial class Department
{
    /// <summary>
    /// Primary key for Department records.
    /// </summary>
    [Key]
    [Column("DepartmentID")]
    public short DepartmentId { get; set; }

    /// <summary>
    /// Name of the department.
    /// </summary>
    [StringLength(50)]
    public string Name { get; set; } = null!;

    /// <summary>
    /// Name of the group to which the department belongs.
    /// </summary>
    [StringLength(50)]
    public string GroupName { get; set; } = null!;

    /// <summary>
    /// Date and time the record was last updated.
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }

    [InverseProperty("Department")]
    public virtual ICollection<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; } = new List<EmployeeDepartmentHistory>();
}
