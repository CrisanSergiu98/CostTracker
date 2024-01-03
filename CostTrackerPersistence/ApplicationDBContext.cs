using CostTrackerDomain.Aggregates;
using Microsoft.EntityFrameworkCore;

namespace CostTrackerPersistence;

public class ApplicationDBContext: DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer();
    }

    public DbSet<Label> Labels { get; set; } = null!;
}
