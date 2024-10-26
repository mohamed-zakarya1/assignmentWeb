using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using web.dtos;
using web.repos;

namespace web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoyaltyController : ControllerBase
    {
        private readonly ILoyaltyCardRepository _db;
        public LoyaltyController(ILoyaltyCardRepository db)
        {
            _db = db;
        }
        [HttpGet]
        public IActionResult GetAllLoyalty()
        {
            return Ok(_db.getAll());
        }
        [HttpGet("{id}")]
        public IActionResult GetByIdLoyalty([FromRoute] int id)
        {
            return Ok(_db.getById(id));
        }
        [HttpPost]
        public IActionResult insertLoyalty([FromBody] loyaltyCardDto users)
        {
            return Ok(_db.insertUser(users));
        }
        [HttpPut]
        public IActionResult updateLoyalty([FromRoute] int id, [FromBody] loyaltyCardDto users)
        {
            return Ok(_db.updateUser(id, users));
        }
        [HttpDelete]
        public IActionResult deleteLoyalty([FromRoute] int id)
        {
            return Ok(_db.deleteUser(id));
        }
    }
}
