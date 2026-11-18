using Microsoft.EntityFrameworkCore;

namespace Cartora.Data
{
    public class CartoraDbContext : DbContext
    {
        public CartoraDbContext(DbContextOptions<CartoraDbContext> options)
            : base(options)
        {
        }

        // We will add DbSet<...> properties here in Part 2,
        // one for each table (Products, Categories, Orders, etc.)
    }
}