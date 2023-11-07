using GamesStore.Web.Models;

namespace GamesStore.Web.Components.Pages;

public partial class EditGame
{
    private Game game = new() { Name = string.Empty, Genre = string.Empty, ReleaseDate = DateTime.UtcNow };
}
