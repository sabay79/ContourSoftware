using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreReverseEngineering.ModelWithAnnotation;

/// <summary>
/// Work shift lookup table.
/// </summary>
[Table("Shift", Schema = "HumanResources")]
[Index("Name", Name = "AK_Shift_Name", IsUnique = true)]
[Index("StartTime", "EndTime", Name = "AK_Shift_StartTime_EndTime", IsUnique = true)]
public partial class Shift
{
    /// <summary>
    /// Primary key for Shift records.
    /// </summary>
    [Key]
    [Column("ShiftID")]
    public byte ShiftId { get; set; }

    /// <summary>
    /// Shift description.
    /// </summary>
    [StringLength(50)]
    public string Name { get; set; } = null!;

    /// <summary>
    /// Shift start time.
    /// </summary>
    public TimeSpan StartTime { get; set; }

    /// <summary>
    /// Shift end time.
    /// </summary>
    public TimeSpan EndTime { get; set; }

    /// <summary>
    /// Date and time the record was last updated.
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }

    [InverseProperty("Shift")]
    public virtual ICollection<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; } = new List<EmployeeDepartmentHistory>();
}
