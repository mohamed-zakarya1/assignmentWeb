using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using web.dtos;
using web.repos;

namespace web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PieceController : ControllerBase
    {
        private readonly IPieceOfArtRepository _db;
        public PieceController(IPieceOfArtRepository db)
        {
            _db = db;
        }
        [HttpGet]
        public IActionResult GetAllPiece()
        {
            return Ok(_db.getAll());
        }
        [HttpGet("{id}")]
        public IActionResult GetByIdPiece([FromRoute] int id)
        {
            return Ok(_db.getById(id));
        }
        [HttpPost]
        public IActionResult insertPiece([FromBody] pieceOfArtDto users)
        {
            return Ok(_db.insertUser(users));
        }
        [HttpPut]
        public IActionResult updatePiece([FromRoute] int id, [FromBody] pieceOfArtDto users)
        {
            return Ok(_db.updateUser(id, users));
        }
        [HttpDelete]
        public IActionResult deletePiece([FromRoute] int id)
        {
            return Ok(_db.deleteUser(id));
        }
    }
}
