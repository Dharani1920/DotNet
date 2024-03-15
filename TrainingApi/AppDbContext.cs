using Microsoft.EntityFrameworkCore;

namespace TrainingApi
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<EmployeeWF> E_Details { get; set; }
        public DbSet<EmployeePositionWF> E_Position { get; set; }
    }
}
