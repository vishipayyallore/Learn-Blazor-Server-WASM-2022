using GamesStore.Web.Models;

namespace GamesStore.Web.Services;

public static class GameClient
{
    static private readonly List<Game> games =
    [
        new Game { Id = 1, Name = "Super Mario Bros", Genre = "Platformer", Price = 59.99M, ReleaseDate = new DateTime(1985, 09, 13) },
        new Game() { Id = 2, Name = "Street Fighter II", Genre = "Fighting", Price = 19.99M, ReleaseDate = new DateTime(1991, 2, 1) },
        new Game() { Id = 3, Name = "Final Fantasy XIV", Genre = "Roleplaying", Price = 59.99M, ReleaseDate = new DateTime(2010, 9, 30) },
        new Game() { Id = 4, Name = "FIFA 23", Genre = "Sports", Price = 69.99M, ReleaseDate = new DateTime(2022, 9, 27) },
        new Game { Id = 5, Name = "Super Mario Bros 2", Genre = "Platformer", Price = 59.99M, ReleaseDate = new DateTime(1988, 10, 09) },
    ];

    public static Game[] GetGames() => [.. games];
}
