using Microsoft.EntityFrameworkCore;

namespace WebApplication_Hotel_Management.Room
{
    public class RoomsDbContext : DbContext
    {
        public RoomsDbContext(DbContextOptions<RoomsDbContext>actions):base(actions)
        {
            
        }
        public DbSet<Rooms> Rooms { get; set; }
    }
}
