using DAL.EF;
using DAL.Interfaces;
using System.Linq;

namespace DAL.Repos
{
    public class UserRepository : IUserRepository
    {
        private readonly TravelExpenseDbContext db;

        public UserRepository(TravelExpenseDbContext context)
        {
            db = context;
        }

        public void Add(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }

        public User GetByEmail(string email)
        {
            return db.Users.FirstOrDefault(u => u.Email == email);
        }
    }
}