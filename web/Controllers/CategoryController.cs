using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using web.dtos;
using web.repos;

namespace web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _db;
        public CategoryController(ICategoryRepository db)
        {
            _db = db;
        }
        [HttpGet]
        public IActionResult GetAllCategory()
        {
            return Ok(_db.getAll());
        }
        [HttpGet("{id}")]
        public IActionResult GetByIdCategory([FromRoute] int id)
        {
            return Ok(_db.getById(id));
        }
        [HttpPost]
        public IActionResult insertCategory([FromBody] categoryDto users)
        {
            return Ok(_db.insertUser(users));
        }
        [HttpPut]
        public IActionResult updateCategory([FromRoute] int id, [FromBody] categoryDto users)
        {
            return Ok(_db.updateUser(id, users));
        }
        [HttpDelete]
        public IActionResult deleteCategory([FromRoute] int id)
        {
            return Ok(_db.deleteUser(id));
        }
    }
}
