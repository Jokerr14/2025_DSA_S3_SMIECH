using System.Configuration;
using DSaA_Project_TimeTracker.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace DSaA_Project_TimeTracker.Database;

public class TTDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = ConfigurationManager.ConnectionStrings["TTDB"].ConnectionString;
        optionsBuilder.UseSqlServer(connectionString);
    }
}
