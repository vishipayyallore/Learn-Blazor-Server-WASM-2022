using HR.LeaveManagement.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace HR.LeaveManagement.Domain;

public class LeaveType : BaseEntity
{
    [Required]
    public string? Name { get; set; }

    public int DefaultDays { get; set; }
}
