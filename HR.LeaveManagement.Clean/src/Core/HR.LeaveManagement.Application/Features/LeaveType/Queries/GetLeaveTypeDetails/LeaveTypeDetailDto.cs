using System.ComponentModel.DataAnnotations;

namespace HR.LeaveManagement.Application.Features.LeaveType.Queries.GetLeaveTypeDetails;

public class LeaveTypeDetailsDto
{
    public int Id { get; set; }

    [Required]
    public string? Name { get; set; }

    public int DefaultDays { get; set; }

    public DateTime? DateCreated { get; set; }

    public DateTime? DateModified { get; set; }
}
