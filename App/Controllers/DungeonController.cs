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
        public ActionResult Index(int id){
            Player player = _playerRepository.GetByUname(User.Identity.Name);
            List<Dungeon> dungeons = _dungeonRepository.GetAll();
            Dungeon dungeon = dungeons.Find(donj => donj.Id == id);
            if(dungeon == null){
                return Redirect("/dungeons");
            }
            if(player.Id != dungeon.DungeonOwner.Id){
                return Redirect("/dungeons");
            }
            DungeonViewModel dungeonModel = new DungeonViewModel(dungeon);
            return View("Index", dungeonModel);
        }

        [HttpPost]
        [Route("[Controller]/{id}")]
        public ActionResult DungeonPlay(int id)
        {
            Player player = _playerRepository.GetByUname(User.Identity.Name);
            List<Dungeon> dungeons = _dungeonRepository.GetAll();
            Dungeon dungeon = dungeons.Find(donj => donj.Id == id);
            if(dungeon == null){
                return Redirect("/dungeons");
            }
            if(player.Id != dungeon.DungeonOwner.Id){
                return Redirect("/dungeons");
            }
            DungeonViewModel dungeonModel = new DungeonViewModel(dungeon);
            return View("Index", dungeonModel);
        }
    }
}