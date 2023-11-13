using GamesStore.Web.Models;
using GamesStore.Web.Services;
using Microsoft.AspNetCore.Components;

namespace GamesStore.Web.Components.Pages;

public partial class EditGame
{
    [Inject]
    public NavigationManager NavigationManager { get; set; } = default!;

    [Parameter]
    public int? Id { get; set; }

    private Game? game;

    private string title = string.Empty;

    protected override void OnParametersSet()
    {
        if (Id is not null)
        {
            Game gameFound = GameClient.GetGame(Id.Value);

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

    private void HandleSubmit()
    {
        if (game?.Id == 0)
        {
            GameClient.AddGame(game);
        }
        else
        {
            GameClient.UpdateGame(game);
        }

        NavigationManager.NavigateTo("/");
    }

    private void Cancel()
    {
        NavigationManager.NavigateTo("/");
    }

}
