using GamesStore.Web.Models;
using GamesStore.Web.Services;
using Microsoft.AspNetCore.Components;

namespace GamesStore.Web.Components.Pages;

public partial class EditGame
{
    [Inject]
    public NavigationManager NavigationManager { get; set; } = default!;

    [Inject]
    public GameClient Client { get; set; } = default!;

    [Parameter]
    public int? Id { get; set; }

    private Game? game;

    private string title = string.Empty;

    protected async override void OnParametersSet()
    {
        if (Id is not null)
        {
            Game gameFound = await Client.GetGameAsync(Id.Value);

            game = new()
            {
                Id = gameFound.Id,
                Name = gameFound.Name,
                Genre = gameFound.Genre,
                Price = gameFound.Price,
                ReleaseDate = gameFound.ReleaseDate
            };

            title = $"Edit {game.Name}";
        }
        else
        {
            game = new() { Name = string.Empty, Genre = string.Empty, ReleaseDate = DateTime.UtcNow };

            title = "New Game";
        }
    }

    private async void HandleSubmit()
    {
        if (game?.Id == 0)
        {
            await Client.AddGameAsync(game);
        }
        else
        {
            await Client.UpdateGameAsync(game!);
        }

        NavigationManager.NavigateTo("/");
    }

    private void Cancel()
    {
        NavigationManager.NavigateTo("/");
    }

}
