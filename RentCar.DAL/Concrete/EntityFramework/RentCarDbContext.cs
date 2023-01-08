using Microsoft.EntityFrameworkCore;
using RentCar.Models.Entities;

namespace RentCar.DAL.Concrete.EntityFramework
{
    public class RentCarDbContext : DbContext
    {
        public RentCarDbContext(DbContextOptions<RentCarDbContext> dbContext) : base(dbContext)
        {

        }
        public DbSet<Cars> Cars { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<EngineTypes> EngineTypes { get; set; }
        public DbSet<Images> Images { get; set; }
        public DbSet<Marks> Marks { get; set; }
        public DbSet<Models.Entities.Models> Models { get; set; }
        public DbSet<Orders> Orders { get; set; }
    }
}
