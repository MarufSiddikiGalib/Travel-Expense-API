using System;
using System.Collections.Generic;

namespace DAL.EF
{
    public class TravelRequest
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Destination { get; set; }
        public string Purpose { get; set; }
        public string Status { get; set; } // e.g., Pending, Approved, Rejected

        public virtual User User { get; set; }
        public virtual ICollection<ExpenseClaim> ExpenseClaims { get; set; }
    }
}