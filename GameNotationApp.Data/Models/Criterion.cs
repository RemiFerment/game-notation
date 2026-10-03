namespace GameNotationApp.Data.Models;

public class Criterion
{
    public required int Id { get; set; }
    public required string Name { get; set; }
    public required float Weight { get; set; }
    public required bool IsActive { get; set; }
    public required int Grade { get; set; }

    public required Category Category { get; set; }
}