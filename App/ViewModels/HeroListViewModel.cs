using System;
using App.Models;

namespace App.ViewModels
{
    public class HeroListViewModel
    {
        public List<Hero> HeroList { get; set; }

        public HeroListViewModel(List<Hero> heroList)
        {
            HeroList = heroList;
        }
    }
}