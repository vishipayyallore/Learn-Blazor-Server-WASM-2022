using System.ComponentModel.DataAnnotations;

namespace CoffeeShop.Data.Entities;

public class Department
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    [StringLength(50)]
    public string? Name { get; set; }

    public List<Employee> Employees { get; set; } = new();
}