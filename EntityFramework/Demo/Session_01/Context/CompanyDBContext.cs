using Microsoft.EntityFrameworkCore;

namespace Session_01.Context;

public class CompanyDbContext: DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Database=CompanyDB;User Id=marwan;Password=A102030;");    }
    public DbSet<Employee> Employees { get; set; }
}
