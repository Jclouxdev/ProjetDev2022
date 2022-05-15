namespace App.Models
{
    public class DungeonRoom
    {
        public int Id { get; set; }
        public List<Monster> Monsters { get; set; }
        public List<Drop> Drops { get; set; }
        public DungeonRoom(List<Monster> monsters, List<Drop> drops){
            Monsters = monsters;
            Drops = drops;
        }
    }
}