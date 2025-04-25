using Microsoft.EntityFrameworkCore;

namespace WebApplication_Hotel_Management.Guest
{
    public class GuestsDbContext: DbContext
    {
        public GuestsDbContext(DbContextOptions<GuestsDbContext> options)
   : base(options)
        {

        }

        public DbSet<Guests> Guest { get; set; }
    }
}
