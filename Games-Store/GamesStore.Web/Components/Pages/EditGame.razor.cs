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
        }
        else
        {
            game = new() { Name = string.Empty, Genre = string.Empty, ReleaseDate = DateTime.UtcNow };
        }
    }

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
