using Microsoft.AspNetCore.Mvc;
using api.Models.Database;

namespace api.Controllers;

[ApiController]
[Route("[controller]")]
public class PokemonController : Controller
{
    [HttpGet("{id}")]
    public Pokemon GetById([FromRoute] int id)
    {
        return new Pokemon
        {
            Id = id,
            Name = "Snorlax",
        };
    }
}