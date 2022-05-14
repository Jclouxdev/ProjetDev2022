using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using App.Models;
using App.ViewModels;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using App.Data;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;

namespace App.Controllers
{
    public class LoginController : Controller
    {
        [BindProperty]
        public LoginPlayerRequest Credentials {get; set;}
        private readonly IPlayerRepository<Player> _playerRepository;
        public LoginController(IPlayerRepository<Player> playerRepository){
            _playerRepository = playerRepository;
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

            bool uNameExists = _playerRepository.AnyName(Credentials.UserName);
            bool mailExists = _playerRepository.AnyMail(Credentials.UserName);
            if(uNameExists || mailExists){
                Player player;
               if(uNameExists){
                   player = _playerRepository.GetByUname(Credentials.UserName);
               } else {
                   player = _playerRepository.GetByMail(Credentials.UserName);
               }
                string salt = player.Salt;
                byte[] hashedPass = KeyDerivation.Pbkdf2(Credentials.Password,Convert.FromBase64String(salt),KeyDerivationPrf.HMACSHA512,10000,32);
                bool rightPassword = Convert.ToBase64String(hashedPass) == player.Password;
                if(rightPassword){
                    var claims = new List<Claim> {
                        new Claim(ClaimTypes.Name, player.Name),
                        new Claim(ClaimTypes.Email, player.Email),
                        new Claim("CreationDate", player.CreationDate.ToShortDateString())
                    };
                    var identity = new ClaimsIdentity(claims, "AuthCookie");
                    ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);

                    await HttpContext.SignInAsync("AuthCookie", claimsPrincipal);
                    return Redirect("/");
                }
            }
            ModelState.AddModelError("","");
            return View("index");
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}