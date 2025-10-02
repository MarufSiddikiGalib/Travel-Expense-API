using System;

namespace DAL.EF
{
    public class ExpenseClaim
    {
        public int Id { get; set; }
        public int TravelRequestId { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string Category { get; set; } // e.g., Transport, Food, Hotel
        public string Description { get; set; }
        public string Status { get; set; } // e.g., Submitted, Approved, Rejected

        public virtual TravelRequest TravelRequest { get; set; }
    }
}