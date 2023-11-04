using System.ComponentModel.DataAnnotations;

namespace GamesStore.Web.Models;

public class Game
{
    public int Id { get; set; }

    [StringLength(50)]
    public required string Name { get; set; }

    [StringLength(20)]
    public required string Genre { get; set; }

    [Range(1, 100)]
    public decimal Price { get; set; }

    public DateTime ReleaseDate { get; set; }
}
