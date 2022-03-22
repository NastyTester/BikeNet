using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> opsions) : base(opsions)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
