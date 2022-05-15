using System;
using App.Models;

namespace App.ViewModels
{
    public class DungeonsListViewModel
    {
        public List<Dungeon> DungeonList { get; set; }

        public DungeonsListViewModel(List<Dungeon> dungeons)
        {
            DungeonList = dungeons;
        }
    }
}