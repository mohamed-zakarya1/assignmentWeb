using web.data.models;
using web.dtos;
namespace web.repos
{
    public interface IUserRepository
    {
        public List<user> getAll();
        public List<user> getWithCard();
        public user getById(int id);
        public int insertUser(userDto user);
        public int updateUser(int id, userDto user);
        public int deleteUser(int id);
    }
}
