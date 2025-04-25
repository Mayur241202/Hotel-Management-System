using Microsoft.EntityFrameworkCore;

namespace WebApplication_Hotel_Management.User
{
    public class UsersDbContext : DbContext
    {
        public UsersDbContext(DbContextOptions<UsersDbContext> options) : base(options)
        {
        }

        public DbSet<Users> Users { get; set; }

    }
}
