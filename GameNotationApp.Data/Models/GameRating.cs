namespace GameNotationApp.Data.Models;

public class GameRating
{
    public int Id { get; set; }
    public required string Comment { get; set; }
    public float FinalScore { get; set; }
    public DateTime CreatedAt { get; set; }

    public required User User {get;set;}
}