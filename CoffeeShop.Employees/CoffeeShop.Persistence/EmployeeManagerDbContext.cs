using CoffeeShop.Data.Entities;
using CoffeeShop.Persistence.Utilities;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.Persistence;

public class EmployeeManagerDbContext : DbContext
{
    public EmployeeManagerDbContext(DbContextOptions<EmployeeManagerDbContext> options) : base(options)
    {
    }

    public DbSet<Employee> Employees => Set<Employee>();

    public DbSet<Department> Departments => Set<Department>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        _ = modelBuilder.Entity<Department>().HasData(EmployeeManagerDataHelper.GetDepartments());

        _ = modelBuilder.Entity<Employee>().HasData(EmployeeManagerDataHelper.GetEmployees());
    }

}
