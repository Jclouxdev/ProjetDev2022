using App.Models;
using App.ViewModels;
using App.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class RegisterController : Controller
    {
        private readonly IPlayerRepository<Player> _playerRepository;
        public RegisterController(IPlayerRepository<Player> playerRepository)
        {
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
        public ActionResult Index(CreatePlayerRequest player)
        {
            try
            {
                if(ModelState.IsValid){
                // TODO: Add insert logic here
                    if(!_playerRepository.AnyMail(player.Email)){
                        Player newPlayer = new(){
                            Email=player.Email,
                            Password=player.Password
                        };
                        _playerRepository.Add(newPlayer);
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