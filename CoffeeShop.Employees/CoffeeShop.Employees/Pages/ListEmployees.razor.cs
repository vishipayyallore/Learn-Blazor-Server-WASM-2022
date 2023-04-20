using CoffeeShop.Data.Entities;
using CoffeeShop.Persistence;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.Employees.Pages;

public partial class ListEmployees
{

    [Parameter]
    public int? CurrentPage { get; set; }

    [Inject]
    public IDbContextFactory<EmployeeManagerDbContext>? ContextFactory { get; set; }

    [Inject]
    public NavigationManager? NavigationManager { get; set; }

    private Employee[]? Employees { get; set; }

    private int TotalPages { get; set; }

    private const int ItemsPerPage = 5;

    // During Component Initialization and Every time a Parameter is set.
    protected override async Task OnParametersSetAsync()
    {
        if (CurrentPage is null or < 1)
        {
            NavigationManager!.NavigateTo("/employees/list/1");
            return;
        }

        using var context = await ContextFactory!.CreateDbContextAsync();

        var employeeCount = await context.Employees.CountAsync();

        TotalPages = (employeeCount == 0) ? 1 : (int)Math.Ceiling((double)employeeCount / ItemsPerPage);

        if (CurrentPage > TotalPages)
        {
            NavigationManager!.NavigateTo($"/employees/list/{TotalPages}");

            return;
        }

        var itemsToSkip = (CurrentPage.Value - 1) * ItemsPerPage;

        Employees = await context.Employees
                                        .Include(emp => emp.Department)
                                        .OrderBy(emp => emp.FirstName)
                                        .Skip(itemsToSkip)
                                        .Take(ItemsPerPage)
                                        .ToArrayAsync();
    }

}
