using Journey.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Journey.Infrastructure;
public class JourneyDbContext : DbContext
{
    public DbSet<Trip> Trips { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=C:\\Users\\flavia\\Desktop\\Projetos\\APIPlanner-c-sharp\\Journey\\JourneyDatabase.db");
    }
}
