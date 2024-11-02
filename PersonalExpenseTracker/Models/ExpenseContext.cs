using Microsoft.EntityFrameworkCore;

namespace PersonalExpenseTracker.Models
{
    public class ExpenseContext : DbContext
    {
        public DbSet<Expense> Expenses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.; Database=ExpenseTrackerDB; Trusted_Connection=True; TrustServerCertificate=True; MultipleActiveResultSets=True");
        }
    }
}
