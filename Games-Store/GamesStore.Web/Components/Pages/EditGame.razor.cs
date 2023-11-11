using GamesStore.Web.Models;
using GamesStore.Web.Services;
using Microsoft.AspNetCore.Components;

namespace GamesStore.Web.Components.Pages;

public partial class EditGame
{
    [Inject]
    public NavigationManager NavigationManager { get; set; } = default!;

    private Game game = new() { Name = string.Empty, Genre = string.Empty, ReleaseDate = DateTime.UtcNow };

    private void HandleSubmit()
    {
        GameClient.AddGame(game);

        NavigationManager.NavigateTo("/");
    }

    private void Cancel()
    {
        NavigationManager.NavigateTo("/");
    }

}
