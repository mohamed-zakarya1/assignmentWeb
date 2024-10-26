using web.data.models;
using web.data;
using web.dtos;

namespace web.repos
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _db;
        public CategoryRepository(AppDbContext db)
        {
            _db = db;
        }

        public int deleteUser(int id)
        {
            var userId = _db.Categories.FirstOrDefault(x => x.Id == id);
            if (userId == null)
            {
                return 0;
            }
            _db.Categories.Remove(userId);
            return _db.SaveChanges();
        }

        public List<category> getAll()
        {
            return _db.Categories.ToList();
        }

        public category getById(int id)
        {
            var user = _db.Categories.FirstOrDefault(x => x.Id == id);
            if (user == null)
            {
                return null;
            }
            return user;
        }

        public int insertUser(categoryDto user)
        {
            category user1 = new category
            {
                Name = user.Name,
                Description = user.Description,
            };
            _db.Categories.Add(user1);
            return _db.SaveChanges();
        }

        public int updateUser(int id, categoryDto user)
        {
            var userId = _db.Categories.FirstOrDefault(x => x.Id == id);
            if (userId == null)
            {
                return 0;
            }
            userId = new category
            {
                Name = user.Name,
                Description = user.Description,
            };
            _db.Categories.Update(userId);
            return _db.SaveChanges();
        }
    }
}
