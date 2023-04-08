using System.ComponentModel.DataAnnotations;

namespace CoffeeShop.Data.Entities;

public class Employee
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    [StringLength(50)]
    public string? FirstName { get; set; }

    [Required]
    [StringLength(50)]
    public string? LastName { get; set; }

    public bool IsDeveloper { get; set; }

    [Required]
    public int? DepartmentId { get; set; }

    public Department? Department { get; set; }
}
