using App.Models;

namespace App.ViewModels
{
    public class DungeonViewModel
    {
        public Dungeon Dungeon {get; set;}

        public DungeonViewModel(Dungeon dungeon){
            Dungeon = dungeon;
        }
    }
}