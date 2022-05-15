using System;
using App.Models;

namespace App.ViewModels
{
    public class SpellsListViewModel
    {
        public List<Spell> SpellList { get; set; }

        public SpellsListViewModel(List<Spell> spellList)
        {
            SpellList = spellList;
        }
    }
}