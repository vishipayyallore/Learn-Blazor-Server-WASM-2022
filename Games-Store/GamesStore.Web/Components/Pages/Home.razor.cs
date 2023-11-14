using GamesStore.Web.Models;
using GamesStore.Web.Services;
using Microsoft.AspNetCore.Components;

namespace GamesStore.Web.Components.Pages;

public partial class Home
{
    private Game[]? games;

    [Inject]
    public NavigationManager NavigationManager { get; set; } = default!;

    protected override void OnInitialized()
    {
        games = GameClient.GetGames();
    }

    private void CreateGame()
    {
        NavigationManager.NavigateTo("/game");
    }
    
    private void EditGame(int id)
    {
        NavigationManager.NavigateTo($"/game/{id}");
    }
}
