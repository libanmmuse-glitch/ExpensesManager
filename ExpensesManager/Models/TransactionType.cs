using System.ComponentModel.DataAnnotations;

namespace ExpensesManager.Models
{
    public class TransactionType
    {
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; } = string.Empty; // e.g., "Income", "Expense"

        // Navigation
        public ICollection<Transaction>? Transactions { get; set; }
    }
}
