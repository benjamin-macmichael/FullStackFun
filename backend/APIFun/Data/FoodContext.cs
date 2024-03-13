using Microsoft.EntityFrameworkCore;

namespace APIFun.Data
{
    public class FoodContext : DbContext
    {
        public FoodContext(DbContextOptions<FoodContext> opions) : base(opions) { }

        public DbSet<MarriottFood> Foods { get; set; }
    }
}
