using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using WebApplication_Hotel_Management.Models;
using System.Threading.Tasks;


namespace WebApplication_Hotel_Management.Controllers
{
    public class AccessController : Controller
    {
        public IActionResult Login()
        {

            ClaimsPrincipal ClaimUser = HttpContext.User;
            if (ClaimUser.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Login(VMLogin modelLogin)
        {
            if (modelLogin.Email == "admin13@mayur.com" && modelLogin.Password == "mayur@123")
            {
                List<Claim> claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.NameIdentifier,modelLogin.Email),
                    new Claim("OtherProperties","ExapmpleRole")
                };
                ClaimsIdentity identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                AuthenticationProperties properties = new AuthenticationProperties()
                {
                    AllowRefresh = true,
                };
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(identity), properties);
                return RedirectToAction("Index", "Home");
            }
            ViewData["ValidMessage"] = "Invalid Credentials";
            return View();
        }
    }
}