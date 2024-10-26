using web.data.models;
using web.dtos;

namespace web.repos
{
    public interface ICategoryRepository
    {
        public List<category> getAll();
        public category getById(int id);
        public int insertUser(categoryDto user);
        public int updateUser(int id, categoryDto user);
        public int deleteUser(int id);
    }
}
