using Microsoft.AspNetCore.Mvc;
using api.Models.Database;
using api.Models.Request;
using api.Repositories;

namespace api.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController : Controller
{
    private UsersRepo _usersRepo;

    public UsersController(UsersRepo usersRepo)
    {
        _usersRepo = usersRepo;
    }

    [HttpGet("{id}")]
    public ActionResult<User> GetById([FromRoute] int id)
    {
        try
        {
            return Ok(_usersRepo.GetById(id));
        }
        catch (InvalidOperationException)
        {
            return NotFound();
        }
    }

    [HttpPost("")]
    public ActionResult Create([FromBody] CreateUserRequest createUserRequest)
    {
        var newUser = _usersRepo.Create(createUserRequest);
        return CreatedAtAction(nameof(GetById), new { Id = newUser.Id }, newUser); 
    }
}