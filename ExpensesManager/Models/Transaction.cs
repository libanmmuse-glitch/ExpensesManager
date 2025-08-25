using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpensesManager.Models
{
    public class Transaction
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }

        [Required]
        public DateTime Date { get; set; }

        // FK → Category
        [Required]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        // FK → TransactionType
        [Required]
        public int TransactionTypeId { get; set; }
        public TransactionType? TransactionType { get; set; }
    }
}
