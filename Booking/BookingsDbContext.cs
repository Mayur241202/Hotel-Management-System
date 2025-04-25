using Microsoft.EntityFrameworkCore;
using WebApplication_Hotel_Management.Room;

namespace WebApplication_Hotel_Management.Booking
{
    public class BookingsDbContext : DbContext 
    {
        public BookingsDbContext(DbContextOptions<BookingsDbContext> choices) : base(choices) 
        { 

        }
        public DbSet<Bookings> Booking { get; set; }
    }
}
