using System.Dynamic;
using GameNotationApp.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace GameNotationApp.Data.Configuration;

public class GnDbContext : DbContext
{
    public DbSet<Platform> Platforms{get;set;}
    public DbSet<Category> Categories{get;set;}
    public DbSet<Role> Roles{get;set;}
    public DbSet<Genre> Genres{get;set;}
}
