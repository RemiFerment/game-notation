namespace GameNotationApp.Data.Models;

public class Criterion
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public float Weight { get; set; }
    public bool IsActive { get; set; }
    public int Grade { get; set; }

    public required Category Category { get; set; }
}