using CoffeeShop.Data.Entities;
using Microsoft.AspNetCore.Components;

namespace CoffeeShop.Employees.Shared;

public partial class EmployeeForm
{

    [Parameter]
    public Employee? Employee { get; set; }

    [Parameter]
    public Department[]? Departments { get; set; }

    [Parameter]
    public bool IsBusy { get; set; }

    [Parameter]
    public EventCallback<bool> OnSubmit { get; set; }

    private async Task HandleValidSubmit()
    {
        if (OnSubmit.HasDelegate)
        {
            await OnSubmit.InvokeAsync(true);
        }
    }

    private async Task HandleInvalidSubmit()
    {
        if (OnSubmit.HasDelegate)
        {
            await OnSubmit.InvokeAsync(false);
        }
    }

}
