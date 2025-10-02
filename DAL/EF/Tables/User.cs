using System.Collections.Generic;

namespace DAL.EF
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Role { get; set; } // e.g., Employee, Manager, Admin
        public string Password { get; set; }

        public virtual ICollection<TravelRequest> TravelRequests { get; set; }
    }
}