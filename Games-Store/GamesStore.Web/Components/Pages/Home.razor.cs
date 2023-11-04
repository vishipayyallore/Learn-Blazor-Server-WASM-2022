using GamesStore.Web.Models;

namespace GamesStore.Web.Components.Pages;

public partial class Home
{
    private Game[] games =
    [
        new Game { Id = 1, Name = "Super Mario Bros", Genre = "Platformer", Price = 59.99M, ReleaseDate = DateTime.Parse("1985-09-13") },
    ];

}
