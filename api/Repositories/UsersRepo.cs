using api.Models.Database;
using api.Models.Request;
using Microsoft.EntityFrameworkCore;

namespace api.Repositories;

public class UsersRepo
{
    private PokemonContext _context;

    public UsersRepo(PokemonContext context)
    {
        _context = context;
    }

    public User GetById(int id)
    {
        return _context
            .Users
            .Include(user => user.FavouritePokemon)
            .Single(user => user.Id == id);
    }

    public User Create(CreateUserRequest createUserRequest)
    {
        var newUser = _context.Add(new User
        {
            Name = createUserRequest.Name,
            FavouritePokemon = [],
        });
        _context.SaveChanges();
        return newUser.Entity;
    }
}