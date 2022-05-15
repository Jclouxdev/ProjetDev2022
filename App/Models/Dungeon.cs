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
        public string BgPic {get; set;}
    }
}