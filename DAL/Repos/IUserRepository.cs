using DAL.EF;

namespace DAL.Interfaces
{
    public interface IUserRepository
    {
        void Add(User user);
        User GetByEmail(string email);
        // Add more as needed
    }
}