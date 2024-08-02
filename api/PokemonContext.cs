using api.Models.Database;
using Microsoft.EntityFrameworkCore;

namespace api;


public class PokemonContext : DbContext
{
    
    public required DbSet<User> Users { get; set; }
    public required DbSet<Pokemon> Pokemon { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=;Username=;Password=");
    }
}

