using System.Data.Entity;

namespace DAL.EF
{
    public class TravelExpenseDbContext : DbContext
    {
        // "name=DefaultConnection" must match <connectionStrings> in app.config
        public TravelExpenseDbContext()
            : base("name=DefaultConnection")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<TravelRequest> TravelRequests { get; set; }
        public DbSet<ExpenseClaim> ExpenseClaims { get; set; }
    }
}
