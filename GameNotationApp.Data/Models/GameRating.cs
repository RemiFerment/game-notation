namespace GameNotationApp.Data.Models;

public class GameRating
{
    public required int Id { get; set; }
    public required string Comment { get; set; }
    public required float FinalScore { get; set; }
    public required DateTime CreatedAt { get; set; }

    public required User User {get;set;}
}