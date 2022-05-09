using System;
using App.Models;

namespace App.ViewModels
{
    public class MonstersListViewModel
    {
        public List<Monster> MonsterList { get; set; }

        public MonstersListViewModel(List<Monster> monsterList)
        {
            MonsterList = monsterList;
        }
    }
}