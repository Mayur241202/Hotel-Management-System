using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using WebApplication_Hotel_Management.User;

public class UsersDbContextFactory : IDesignTimeDbContextFactory<UsersDbContext>
{
    public UsersDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<UsersDbContext>();
        optionsBuilder.UseSqlServer("Data Source=Mayur5365\\SQLEXPRESS;Initial Catalog=Hotel_Management;Integrated Security=True;Encrypt=False");

        return new UsersDbContext(optionsBuilder.Options);
    }
}
