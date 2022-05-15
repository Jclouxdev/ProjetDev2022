namespace App.Models
{
    public class Dungeon
    {
        public int Id { get; set; }
        public List<DungeonRoom> Rooms { get; set; }
        public List<Monster> Monsters { get; set; }
        public List<Drop> Drops { get; set; }
        public Player DungeonOwner { get; set; }
        public int Progression { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Name { get; set; }
        public int Difficulty { get; set; }

        public Dungeon(Player owner, List<Monster> monsters, List<Item> items){
            Random rng = new Random();
            int dungeonType = rng.Next(3);
            Difficulty = rng.Next(3);
            string[] dungeonFNames = {"Crypte","Forêt","Montagne"};
            string dungeonFName = dungeonFNames[dungeonType];
            string[] dungeonLNames = {"infernale","puante", "enchantée", "désasteuse","du cauchemar", "enchantée", "menaçante", "dangereuse", "maudite", "des esprits", "diabolique", "des elfes", "du dragon", "de la liche", "putréfiée"};
            string dungeonLName = dungeonLNames[rng.Next(15)];
            Name = dungeonFName + " " + dungeonLName;
            ExpirationDate = DateTime.Now.AddDays(1);
            Progression=0;
            DungeonOwner = owner;
            List<Monster> totalMonsterList = new List<Monster>();
            List<Drop> totalDropList = new List<Drop>();
            List<DungeonRoom> rooms = new List<DungeonRoom>();
            for(int i = 0;i<Difficulty+2;i++){
                List<Monster> roomMonsters = new List<Monster>();
                for(int j =0;j<3;j++){
                    Monster rngMonster = monsters[rng.Next(monsters.Count)];
                    roomMonsters.Add(rngMonster);
                    totalMonsterList.Add(rngMonster);
                }
                List<Drop> roomLoots = new List<Drop>();
                for(int j=0;j<rng.Next(8);j++){
                    Item randItem = items[rng.Next(items.Count)];
                    int probability = (10+Difficulty)*rng.Next(1,5);
                    Drop newDrop = new Drop(randItem, probability);
                    roomLoots.Add(newDrop);
                    totalDropList.Add(newDrop);
                }
                rooms.Add(new DungeonRoom(roomMonsters,roomLoots));
            }
            Rooms = rooms;
            Monsters = totalMonsterList;
            Drops = totalDropList;
        }
    }
}