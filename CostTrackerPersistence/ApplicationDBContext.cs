using Microsoft.EntityFrameworkCore;

namespace CostTrackerPersistence;

public class ApplicationDBContext: DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer();
    }
}
