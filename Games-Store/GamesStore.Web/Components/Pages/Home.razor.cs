using GamesStore.Web.Models;
using GamesStore.Web.Services;
using Microsoft.AspNetCore.Components;

namespace GamesStore.Web.Components.Pages;

public partial class Home
{
    private Game[]? games;

    private Game? currentGame;

    [Inject]
    public NavigationManager NavigationManager { get; set; } = default!;

    [Inject]
    public GameClient Client { get; set; } = default!;

    protected override async Task OnInitializedAsync()
    {
        games = await Client.GetGamesAsync();
    }

    private void CreateGame()
    {
        NavigationManager.NavigateTo("/game");
    }

    private void EditGame(int id)
    {
        NavigationManager.NavigateTo($"/game/{id}");
    }

    private async void OnDeleteModalClose(bool accepted)
    {
        if (accepted)
        {
            await Client.DeleteGameAsync(currentGame!.Id);

            games = await Client.GetGamesAsync();
        }
    }
}
