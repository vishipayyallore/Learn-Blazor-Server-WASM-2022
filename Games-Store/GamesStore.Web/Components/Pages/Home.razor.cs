using GamesStore.Web.Models;
using GamesStore.Web.Services;

namespace GamesStore.Web.Components.Pages;

public partial class Home
{
    private Game[]? games;

    protected override void OnInitialized()
    {
        games = GameClient.GetGames();
    }

}
