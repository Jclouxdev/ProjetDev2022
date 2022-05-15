namespace App.Models
{
    public class DungeonRoom
    {
        public int Id { get; set; }
        public List<Monster> Monsters { get; set; }
        public List<Drop> Drops { get; set; }
    }
}