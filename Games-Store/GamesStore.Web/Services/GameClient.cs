using GamesStore.Web.Models;
using System.Net.Http.Json;

namespace GamesStore.Web.Services;

public class GameClient(HttpClient httpClient)
{
    private readonly HttpClient httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));

    public async Task<Game[]?> GetGamesAsync()
    {
        return await httpClient.GetFromJsonAsync<Game[]>("games");
    }

    public async Task AddGameAsync(Game game)
    {
        await httpClient.PostAsJsonAsync("games", game);
    }

    public async Task<Game> GetGameAsync(int id)
    {
        return await httpClient.GetFromJsonAsync<Game>($"games/{id}") ?? throw new Exception("Could not find game!");
    }

    public async Task UpdateGameAsync(Game updatedGame)
    {
        await httpClient.PutAsJsonAsync($"games/{updatedGame.Id}", updatedGame);
    }

    public async Task DeleteGameAsync(int id)
    {
        await httpClient.DeleteAsync($"games/{id}");
    }
}
