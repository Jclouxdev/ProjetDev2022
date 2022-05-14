using App.Models;
using App.ViewModels;
using App.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;

namespace App.Controllers
{
    public class RegisterController : Controller
    {
        private readonly IPlayerRepository<Player> _playerRepository;

        public RegisterController(IPlayerRepository<Player> playerRepository){
            _playerRepository = playerRepository;
        }

        // GET: Register
        [HttpGet]
        [Route("Register")]
        public ActionResult Index()
        {
            return View("Index");
        }

        [HttpPost]
        [Route("Register")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(CreatePlayerRequest player)
        {
            try
            {
                if(ModelState.IsValid){
                    // TODO: Add insert logic here
                    bool mailOrUnameTaken = _playerRepository.AnyName(player.UserName) || _playerRepository.AnyName(player.Email) || _playerRepository.AnyMail(player.Email) || _playerRepository.AnyMail(player.UserName);
                    if(!mailOrUnameTaken){
                        byte[] salt = new byte[32];
                        var rngCsp = new RNGCryptoServiceProvider();
                        rngCsp.GetNonZeroBytes(salt);
                        string hashedPassword = Convert.ToBase64String(KeyDerivation.Pbkdf2(player.Password,salt,KeyDerivationPrf.HMACSHA512,10000,32));
                        string saltString = Convert.ToBase64String(salt);
                        Player newPlayer = new(){
                            CreationDate=DateTime.Now,
                            Email=player.Email,
                            Name=player.UserName,
                            Password=hashedPassword,
                            Salt=saltString
                        };
                        _playerRepository.Add(newPlayer);
                        _playerRepository.Commit();
                        var claims = new List<Claim> {
                        new Claim(ClaimTypes.Name, player.UserName),
                        new Claim(ClaimTypes.Email, player.Email),
                        new Claim("CreationDate", newPlayer.CreationDate.ToShortDateString())
                    };
                    var identity = new ClaimsIdentity(claims, "AuthCookie");
                    ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);

                    await HttpContext.SignInAsync("AuthCookie", claimsPrincipal);
                    return Redirect("/");
                    }
                }
                return View();
            }
            catch
            {
                return View();
            }
        }
    }
}