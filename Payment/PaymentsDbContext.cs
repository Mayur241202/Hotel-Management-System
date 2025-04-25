using Microsoft.EntityFrameworkCore;
using WebApplication_Hotel_Management.Booking;

namespace WebApplication_Hotel_Management.Payment
{
    public class PaymentsDbContext : DbContext
    {
        public PaymentsDbContext(DbContextOptions <PaymentsDbContext>picubs):base(picubs)
        { 

        }
        public DbSet<Payments> Payment { get; set; }
    }
}
