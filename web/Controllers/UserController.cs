using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using web.dtos;
using web.repos;

namespace web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _db;
        public UserController(IUserRepository db)
        {
            _db = db;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_db.getAll());
        }
        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            return Ok(_db.getById(id));
        }
        [HttpGet("card")]
        public IActionResult GetByCard()
        {
            return Ok(_db.getWithCard());
        }
        [HttpPost]
        public IActionResult insertUser([FromBody] userDto users) 
        {
            return Ok(_db.insertUser(users));
        }
        [HttpPut]
        public IActionResult updateUser([FromRoute] int id, [FromBody] userDto users)
        {
            return Ok(_db.updateUser(id, users));
        }
        [HttpDelete]
        public IActionResult deleteUser([FromRoute] int id)
        {
            return Ok(_db.deleteUser(id));
        }
    }
}
