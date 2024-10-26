using web.data.models;
using web.data;
using web.dtos;

namespace web.repos
{
    public class PieceOfArtRepository : IPieceOfArtRepository
    {
        private readonly AppDbContext _db;
        public PieceOfArtRepository(AppDbContext db)
        {
            _db = db;
        }
        public int deleteUser(int id)
        {
            var userId = _db.Arts.FirstOrDefault(x => x.Id == id);
            if (userId == null)
            {
                return 0;
            }
            _db.Arts.Remove(userId);
            return _db.SaveChanges();
        }

        public List<pieceOfArt> getAll()
        {
            return _db.Arts.ToList();
        }

        public pieceOfArt getById(int id)
        {
            var user = _db.Arts.FirstOrDefault(x => x.Id == id);
            if (user == null)
            {
                return null;
            }
            return user;
        }

        public int insertUser(pieceOfArtDto user)
        {
            pieceOfArt piece = new pieceOfArt {
                Title = user.Title,
                Price = user.Price,
                CategoryId = user.CategoryIdDto,
                Publication_date = user.Publication_date,
                userId = user.userIdDto,
            };
            _db.Arts.Add(piece);
            return _db.SaveChanges();
        }

        public int updateUser(int id, pieceOfArtDto user)
        {
            var userId = _db.Arts.FirstOrDefault(x => x.Id == id);
            if (userId == null)
            {
                return 0;
            }
            userId = new pieceOfArt
            {
                Title = user.Title,
                Price = user.Price,
                CategoryId = user.CategoryIdDto,
                Publication_date = user.Publication_date,
                userId = user.userIdDto,
            };
            return _db.SaveChanges();
        }
    }
}
