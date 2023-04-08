using CoffeeShop.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.Persistence;

public class EmployeeManagerDbContext : DbContext
{
    public EmployeeManagerDbContext(DbContextOptions<EmployeeManagerDbContext> options) : base(options)
    {
    }

    public DbSet<Employee> Employees => Set<Employee>();

    public DbSet<Department> Departments => Set<Department>();
}