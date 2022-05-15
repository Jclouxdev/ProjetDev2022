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
        private readonly IRepository<Item> _itemRepository;
        private readonly IRepository<Monster> _monsterRepository;

        public DungeonsController(IRepository<Dungeon> dungeonRepository, IPlayerRepository<Player> playerRepository, IRepository<Item> itemRepository, IRepository<Monster> monsterRepository){
            _dungeonRepository = dungeonRepository;
            _playerRepository = playerRepository;
            _itemRepository = itemRepository;
            _monsterRepository = monsterRepository;
        }

        [HttpGet]
        [Route("[Controller]")]
        public ActionResult Index(){
            Player player = _playerRepository.GetByUname(User.Identity.Name);
            List<Dungeon> dungeons = _dungeonRepository.GetAll();
            List<Dungeon> playerDungeons = dungeons.FindAll(dungeon => dungeon.DungeonOwner == player && DateTime.Compare(dungeon.ExpirationDate,DateTime.Now) > 0);
            if(playerDungeons.Count == 0){
                List<Item> items = _itemRepository.GetAll();
                List<Monster> monsters = _monsterRepository.GetAll();
                playerDungeons = GenerateDungeons(player, monsters, items);
                for(int i=0;i<3;i++){
                    _dungeonRepository.Add(playerDungeons[i]);
                    _dungeonRepository.Commit();
                }
            }
            DungeonsListViewModel dungeonsListViewModel = new DungeonsListViewModel(playerDungeons);
            return View("Index",dungeonsListViewModel);
        }
        static List<Dungeon> GenerateDungeons(Player player, List<Monster> monsters, List<Item> items){
                    List<Dungeon> dungeons = new List<Dungeon>();
                    for(int i=0;i<3;i++){
                        Random rng = new Random();
                        int dungeonType = rng.Next(3);
                        int diff = rng.Next(3);
                        string[] dungeonFNames = {"Crypte","Forêt","Montagne"};
                        string dungeonFName = dungeonFNames[dungeonType];
                        string[] dungeonAssetsLinks = {"assets/dungeons/graveyard.jpg", "assets/dungeons/Forest.jpg", "assets/dungeons/mountain.jpg"};
                        string dungeonBg = dungeonAssetsLinks[dungeonType];
                        string[] dungeonLNames = {"infernale","puante", "enchantée", "désasteuse","du cauchemar", "enchantée", "menaçante", "dangereuse", "maudite", "des esprits", "diabolique", "des elfes", "du dragon", "de la liche", "putréfiée"};
                        string dungeonLName = dungeonLNames[rng.Next(15)];
                        List<Monster> totalMonsterList = new List<Monster>();
                        List<Drop> totalDropList = new List<Drop>();
                        List<DungeonRoom> rooms = new List<DungeonRoom>();
                        for(int k = 0;k<diff+2;k++){
                            List<Monster> roomMonsters = new List<Monster>();
                            for(int j =0;j<3;j++){
                                Monster rngMonster = monsters[rng.Next(monsters.Count)];
                                roomMonsters.Add(rngMonster);
                                totalMonsterList.Add(rngMonster);
                            }
                            List<Drop> roomLoots = new List<Drop>();
                            for(int j=0;j<rng.Next(8);j++){
                                Item randItem = items[rng.Next(items.Count)];
                                int probability = (10+diff)*rng.Next(1,5);
                                Drop newDrop = new Drop(){
                                    Item =randItem,
                                    Probability = probability
                                };
                                roomLoots.Add(newDrop);
                                totalDropList.Add(newDrop);
                            }
                            rooms.Add(new DungeonRoom(){
                                Drops = roomLoots,
                                Monsters = roomMonsters,
                                Completed = false,
                                Failed = false
                            });
                        }
                        dungeons.Add(new Dungeon(){
                            Difficulty = diff,
                            Name = dungeonFName + " " + dungeonLName,
                            ExpirationDate = DateTime.Now.AddDays(1),
                            Progression=0,
                            DungeonOwner = player,
                            Rooms = rooms,
                            Monsters = totalMonsterList,
                            Drops = totalDropList,
                            BgPic = dungeonBg
                        });
            }
            return dungeons;
        }
    }
}