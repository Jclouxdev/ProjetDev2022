using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using App.Models;
using App.ViewModels;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;

namespace App.Controllers
{
    public class LoginController : Controller
    {
        [BindProperty]
        public LoginPlayerRequest Credentials {get; set;}
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        [Route("/login")]

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("/login")]
        public async Task<IActionResult> Login()
        {
            if(!ModelState.IsValid) return View("index");

            // verify credential
            if(Credentials.UserName == "admin" && Credentials.Password == "password"){
                // Creating the security context
                var claims = new List<Claim> {
                    new Claim(ClaimTypes.Name, "admin"),
                    new Claim(ClaimTypes.Email, "admin@test.com")
                };
                var identity = new ClaimsIdentity(claims, "AuthCookie");
                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);

                await HttpContext.SignInAsync("AuthCookie", claimsPrincipal);
                return Redirect("/");
            }
            return View("index");
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}