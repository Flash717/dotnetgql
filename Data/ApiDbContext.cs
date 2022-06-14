using Microsoft.EntityFrameworkCore;

namespace todolistgql
{
    public class ApiDbContext : DbContext
    {
        public DbSet<ItemData> Item { get; set; }
        public DbSet<ItemList> List { get; set; }

        public ApiDbContext(DbContextOptions<ApiDbContext> options): base(options)
        { 
            
        }
    }
}