using GamesStore.Web.Models;
using GamesStore.Web.Services;

namespace GamesStore.Web.Components.Pages;

public partial class EditGame
{
    private Game game = new() { Name = string.Empty, Genre = string.Empty, ReleaseDate = DateTime.UtcNow };

    private void HandleSubmit()
    {
        GameClient.AddGame(game);
    }

}
