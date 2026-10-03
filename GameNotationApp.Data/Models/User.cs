using System.ComponentModel.DataAnnotations;

namespace GameNotationApp.Data.Models;

public class User
{
    public int Id { get; set; }
    public required string Uuid { get; set; }
    public required string Email { get; set; }
    public required string HashPassword { get; set; }
    public required string Username { get; set; }
    public DateTime CreatedAt { get; set; }

    public required Role Role { get; set; }
}