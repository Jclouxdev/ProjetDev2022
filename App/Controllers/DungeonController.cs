using App.Data;
using App.Models;
using App.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class DungeonController : Controller
    {

        private readonly IRepository<Dungeon> _dungeonRepository;
        private readonly IPlayerRepository<Player> _playerRepository;
        private readonly IRepository<Item> _itemRepository;
        private readonly IRepository<Monster> _monsterRepository;

        public DungeonController(IRepository<Dungeon> dungeonRepository, IPlayerRepository<Player> playerRepository, IRepository<Item> itemRepository, IRepository<Monster> monsterRepository){
            _dungeonRepository = dungeonRepository;
            _playerRepository = playerRepository;
            _itemRepository = itemRepository;
            _monsterRepository = monsterRepository;
        }

        [HttpGet]
        [Route("[Controller]/{id}")]
        public ActionResult DungeonPlay(int id){
            if(id<3){
                Player player = _playerRepository.GetByUname(User.Identity.Name);
                List<Dungeon> dungeons = _dungeonRepository.GetAll();
                List<Dungeon> playerDungeons = dungeons.FindAll(dungeon => dungeon.DungeonOwner == player);
                if(playerDungeons.Count == 0){
                    return Redirect("/dungeons");
                }
                DungeonViewModel dungeonModel = new DungeonViewModel(playerDungeons[id]);
                return View("DungeonPlay", dungeonModel);
            }
            return Redirect("/dungeons");
        }
    }
}