namespace GameNotationApp.Data.Models;

public class Game
{
    public required int Id { get; set; }
    public required DateOnly Date { get; set; }
    public required string Name { get; set; }

    public required IList<Platform> Platforms { get; set; }
    public required IList<Genre> Genres { get; set; }
    public required IList<Criterion> Criteria { get; set; }
    public required GameRating GameRating { get; set; }
}