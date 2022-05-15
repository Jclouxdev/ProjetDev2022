using App.Data;
using App.Models;
using App.ViewModels;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class DungeonsController : Controller
    {
        private readonly IRepository<Dungeon> _dungeonRepository;
        private readonly IPlayerRepository<Player> _playerRepository;

        public DungeonsController(IRepository<Dungeon> dungeonRepository, IPlayerRepository<Player> playerRepository){
            _dungeonRepository = dungeonRepository;
            _playerRepository = playerRepository;
        }

        [HttpGet]
        [Route("[Controller]")]
        public ActionResult Index(){
            Player player = _playerRepository.GetByUname(User.Identity.Name);
            List<Dungeon> dungeons = _dungeonRepository.GetAll();
            List<Dungeon> playerDungeons = dungeons.FindAll(dungeon => dungeon.DungeonOwner == player);
            if(playerDungeons.Count == 0){
                playerDungeons = GenerateDungeons(player);
            }
            return View("Index",playerDungeons);
        }

        static List<Dungeon> GenerateDungeons(Player player){
            
        }
    }
}