using web.data.models;
using web.data;
using web.dtos;

namespace web.repos
{
    public class LoyaltyCardRepository : ILoyaltyCardRepository
    {
        private readonly AppDbContext _db;
        public LoyaltyCardRepository(AppDbContext db)
        {
            _db = db;
        }
        public int deleteUser(int id)
        {
            var userId = _db.Cards.FirstOrDefault(x => x.Id == id);
            if (userId == null)
            {
                return 0;
            }
            _db.Cards.Remove(userId);
            return _db.SaveChanges();
        }

        public List<loyaltyCard> getAll()
        {
            return _db.Cards.ToList();
        }

        public loyaltyCard getById(int id)
        {
            var user = _db.Cards.FirstOrDefault(x => x.Id == id);
            if (user == null)
            {
                return null;
            }
            return user;
        }

        public int insertUser(loyaltyCardDto user)
        {
            loyaltyCard card = new loyaltyCard
            {
                Name = user.Name,
                Description = user.Description,
            };
            _db.Cards.Add(card);
            return _db.SaveChanges();
        }

        public int updateUser(int id, loyaltyCardDto user)
        {
            var userId = _db.Cards.FirstOrDefault(x => x.Id == id);
            if (userId == null)
            {
                return 0;
            }
            userId = new loyaltyCard
            {
                Name = user.Name,
                Description = user.Description,
            };
            return _db.SaveChanges();
        }
    }
}
