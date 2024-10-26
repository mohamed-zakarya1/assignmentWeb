using web.data.models;
using web.dtos;

namespace web.repos
{
    public interface ILoyaltyCardRepository
    {
        public List<loyaltyCard> getAll();
        public loyaltyCard getById(int id);
        public int insertUser(loyaltyCardDto user);
        public int updateUser(int id, loyaltyCardDto user);
        public int deleteUser(int id);
    }
}
