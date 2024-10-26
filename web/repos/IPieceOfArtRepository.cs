using web.data.models;
using web.dtos;

namespace web.repos
{
    public interface IPieceOfArtRepository
    {
        public List<pieceOfArt> getAll();
        public pieceOfArt getById(int id);
        public int insertUser(pieceOfArtDto user);
        public int updateUser(int id, pieceOfArtDto user);
        public int deleteUser(int id);
    }
}
