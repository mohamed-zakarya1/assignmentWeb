using Microsoft.EntityFrameworkCore;
using web.data;
using web.data.models;
using web.dtos;

namespace web.repos
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _db;
        public UserRepository(AppDbContext db)
        {
            _db = db;
        }
        public int deleteUser(int id)
        {
            var userId = _db.Users.FirstOrDefault(x => x.Id == id);
            if (userId == null)
            {
                return 0;
            }
            _db.Users.Remove(userId);
            return _db.SaveChanges();
        }

        public List<user> getAll()
        {
            return _db.Users.ToList();
        }
        public List<user> getWithCard()
        {
           return _db.Users.Include(x => x.Card).ToList();
        }

        public user getById(int id)
        {
            var user = _db.Users.FirstOrDefault(x => x.Id == id);
            if (user == null)
            {
                return null;
            }
            return user;
        }
        public int insertUser(userDto user)
        {
            user user1 = new user
            {
                Name = user.Name,
                Email = user.Email,
                LoyaltyId = user.LoyaltyIdDto,
                age = user.age,
            };
            _db.Users.Add(user1);
            return _db.SaveChanges();
        }

        public int updateUser(int id, userDto user)
        {
            var userId = _db.Users.FirstOrDefault(x => x.Id == id);
            if (userId == null)
            {
                return 0;
            }
            userId = new user
            {
                Name = user.Name,
                age = user.age,
                Email = user.Email,
                LoyaltyId = user.LoyaltyIdDto,
            };
            _db.Users.Update(userId);
            return _db.SaveChanges();
        }
    }
}