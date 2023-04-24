using CoffeeShop.Data.Entities;
using CoffeeShop.Employees.Shared;
using CoffeeShop.Persistence;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.JSInterop;

namespace CoffeeShop.Employees.Pages;

public partial class ListEmployees
{

    [Parameter]
    public int? CurrentPage { get; set; }

    [Inject]
    public IDbContextFactory<EmployeeManagerDbContext>? ContextFactory { get; set; }

    [Inject]
    public NavigationManager? NavigationManager { get; set; }

    [Inject]
    public StateContainer? StateContainer { get; set; }

    [Inject]
    public IJSRuntime? JS { get; set; }

    private Employee[]? Employees { get; set; }

    private int TotalPages { get; set; }

    private const int ItemsPerPage = 5;

    // During Component Initialization and Every time a Parameter is set.
    protected override async Task OnParametersSetAsync()
    {
        await LoadData();
    }

    private async Task LoadData()
    {
        if (CurrentPage is null or < 1)
        {
            NavigationManager!.NavigateTo("/employees/list/1");
            return;
        }

        using var context = ContextFactory!.CreateDbContext();

        var employeeCount = await context.Employees.CountAsync();
        TotalPages = employeeCount == 0
          ? 1
          : (int)Math.Ceiling((double)employeeCount / ItemsPerPage);

        if (CurrentPage > TotalPages)
        {
            NavigationManager!.NavigateTo($"/employees/list/{TotalPages}");
            return;
        }

        StateContainer!.ListEmployees = CurrentPage.Value;

        var itemsToSkip = (CurrentPage.Value - 1) * ItemsPerPage;

        Employees = await context.Employees
          .Include(emp => emp.Department)
          .OrderBy(emp => emp.FirstName)
          .Skip(itemsToSkip)
          .Take(ItemsPerPage)
          .ToArrayAsync();
    }

    private async Task HandleDelete(Employee employee)
    {
        var isOk = await JS!.InvokeAsync<bool>("confirm",
          $"Delete employee {employee.FirstName} {employee.LastName}?");

        if (isOk)
        {
            using var context = ContextFactory!.CreateDbContext();
            context.Employees.Remove(employee);
            await context.SaveChangesAsync();

            await LoadData();
        }
    }

}
