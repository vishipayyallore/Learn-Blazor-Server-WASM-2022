using GamesStore.Web.Models;
using Microsoft.AspNetCore.Components;

namespace GamesStore.Web.Components.Pages;

public partial class DeleteGame
{
    [Parameter]
    public Game? Game { get; set; }

    [Parameter]
    public EventCallback<bool> OnClose { get; set; }

    private string title = string.Empty;

    protected override void OnParametersSet()
    {
        title = $"Delete {Game?.Name}?";
    }

    private void Confirm()
    {
        OnClose.InvokeAsync(true);
    }

    private void Cancel()
    {
        OnClose.InvokeAsync(false);
    }
}
