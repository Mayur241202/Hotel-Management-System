using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using WebApplication_Hotel_Management.Booking;
using WebApplication_Hotel_Management.Guest;
using WebApplication_Hotel_Management.Payment;
using WebApplication_Hotel_Management.Room;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddAuthentication(
   CookieAuthenticationDefaults.AuthenticationScheme)
   .AddCookie(option =>
   {
       option.LoginPath = "/Access/Login";
       option.ExpireTimeSpan = TimeSpan.FromMinutes(20);
   });

builder.Services.AddDbContext<GuestsDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddDbContext<RoomsDbContext>(actions =>
{
    actions.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddDbContext<BookingsDbContext>(choices =>
{
    choices.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddDbContext<PaymentsDbContext>(pickups =>
{
    pickups.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Access}/{action=Login}/{id?}");

app.Run();
