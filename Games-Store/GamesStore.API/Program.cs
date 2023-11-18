using GamesStore.API.Models;

List<Game> games =
    [
        new Game { Id = 1, Name = "Super Mario Bros", Genre = "Platformer", Price = 59.99M, ReleaseDate = new DateTime(1985, 09, 13) },
        new Game { Id = 2, Name = "Street Fighter II", Genre = "Fighting", Price = 19.99M, ReleaseDate = new DateTime(1991, 2, 1) },
        new Game { Id = 3, Name = "Final Fantasy XIV", Genre = "Roleplaying", Price = 59.99M, ReleaseDate = new DateTime(2010, 9, 30) },
        new Game { Id = 4, Name = "FIFA 23", Genre = "Sports", Price = 69.99M, ReleaseDate = new DateTime(2022, 9, 27) },
        new Game { Id = 5, Name = "Super Mario Bros 2", Genre = "Platformer", Price = 59.99M, ReleaseDate = new DateTime(1988, 10, 09) },
    ];

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options => options.AddDefaultPolicy(builder =>
{
    builder.WithOrigins("https://localhost:7290")
                    .AllowAnyHeader()
                    .AllowAnyMethod();
}));

var app = builder.Build();

app.UseCors();

var group = app.MapGroup("/ep/games")
                .WithParameterValidation();

// GET /ep/games
group.MapGet("/", () => games);

// GET /games/{id}
group.MapGet("/{id}", (int id) =>
{
    Game? game = games.Find(game => game.Id == id);

    if (game is null)
    {
        return Results.NotFound();
    }

    return Results.Ok(game);
})
.WithName("GetGame");

// POST /games
group.MapPost("/", (Game game) =>
{
    game.Id = games.Max(game => game.Id) + 1;
    games.Add(game);

    return Results.CreatedAtRoute("GetGame", new { id = game.Id }, game);
});

// PUT /games/{id}
group.MapPut("/{id}", (int id, Game updatedGame) =>
{
    Game? existingGame = games.Find(game => game.Id == id);

    if (existingGame is null)
    {
        updatedGame.Id = id;
        games.Add(updatedGame);
        return Results.CreatedAtRoute("GetGame", new { id = updatedGame.Id }, updatedGame);
    }

    existingGame.Name = updatedGame.Name;
    existingGame.Genre = updatedGame.Genre;
    existingGame.Price = updatedGame.Price;
    existingGame.ReleaseDate = updatedGame.ReleaseDate;

    return Results.NoContent();
});

// DELETE /games/{id}
group.MapDelete("/{id}", (int id) =>
{
    Game? game = games.Find(game => game.Id == id);

    if (game is null)
    {
        return Results.NotFound();
        //return Results.NoContent();
    }

    games.Remove(game);

    return Results.NoContent();
});

app.Run();
