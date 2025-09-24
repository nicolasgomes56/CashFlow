using CashFlow.Domain.Entites;
using Microsoft.EntityFrameworkCore;

namespace CashFlow.Infrastructure.DataAccess;

public class CashFlowDbContext : DbContext
{
    public DbSet<Expense> Expenses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = "Server=localhost;Database=cashflow_db;Uid=cashflow_user;Pwd=cashflow@123";
        var serverVersion = new MySqlServerVersion(new Version(8, 4, 0));

        optionsBuilder.UseMySql(connectionString, serverVersion);
    }
}
