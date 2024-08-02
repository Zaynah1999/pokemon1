namespace api.Models.Database;

public class User
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required List<Pokemon> FavouritePokemon { get; set; }
}