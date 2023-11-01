using IncomeExpense_WPF.Model;
using Microsoft.EntityFrameworkCore;

namespace IncomeExpense_WPF.Data
{
    public class IncomeExpenseDbContext : DbContext
    {
        public IncomeExpenseDbContext() {}

        public DbSet<IncomeExpense> incomeExpense { get; set;}

        public IncomeExpenseDbContext(DbContextOptions<IncomeExpenseDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=IncomeExpenseDb;");
            }
        }
    }
}
