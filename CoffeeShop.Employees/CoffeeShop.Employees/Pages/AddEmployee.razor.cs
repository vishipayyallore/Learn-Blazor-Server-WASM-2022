using CoffeeShop.Data.Entities;
using CoffeeShop.Persistence;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.Employees.Pages;

public partial class AddEmployee
{
    [Inject]
    public IDbContextFactory<EmployeeManagerDbContext>? ContextFactory { get; set; }

    private Employee? Employee { get; set; }

    private Department[]? Departments { get; set; }

    private string? SuccessMessage { get; set; }

    private string? ErrorMessage { get; set; }

    private bool IsBusy { get; set; }

    protected override async Task OnInitializedAsync()
    {
        using var context = ContextFactory?.CreateDbContext();

        Departments = await context!.Departments.OrderBy(dept => dept.Name).ToArrayAsync();

        Employee = new()
        {
            DepartmentId = Departments.FirstOrDefault()?.Id
        };
    }

    private async Task HandleSubmit(bool isValid)
    {
        if (isValid)
        {
            await HandleValidSubmit();
        }
        else
        {
            HandleInvalidSubmit();
        }
    }

    private async Task HandleValidSubmit()
    {
        if (IsBusy)
        {
            return;
        }

        IsBusy = true;

        try
        {
            if (Employee is not null)
            {
                using var context = ContextFactory?.CreateDbContext();

                context!.Employees.Add(Employee);
                await context.SaveChangesAsync();

                SuccessMessage = $"Employee {Employee.FirstName} {Employee.LastName} was added successfully.";
                ErrorMessage = null;

                // New Employee for next creation
                Employee = new()
                {
                    DepartmentId = Employee.DepartmentId
                };
            }
        }
        catch (Exception ex)
        {
            SuccessMessage = null;
            ErrorMessage = $"Error while adding employee: {ex.Message}";
        }
        finally
        {
            IsBusy = false;
        }
    }

    private void HandleInvalidSubmit()
    {
        SuccessMessage = null;

        ErrorMessage = null;
    }

}
