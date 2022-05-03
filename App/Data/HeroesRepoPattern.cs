using System;
using App.Models;

namespace App.Data
{
    public class HeroesRepoPattern
    {
        public static List<Hero> GetAllHeroes() 
        {
            var heroes = new List<Hero>()
            {
                new Hero()
                {
                    Id = 1,
                    Name = "Pruxyne",
                    Role = "Dégats",
                    Health = 100,
                    AttackDamage = 50,
                    AbilityPower = 30,
                    Armor = 25,
                    MagicResistance = 25,
                    CritRate = 15
                },
                new Hero()
                {
                    Id = 2,
                    Name = "Kleomasose",
                    Role = "Tank",
                    Health = 200,
                    AttackDamage = 20,
                    AbilityPower = 30,
                    Armor = 50,
                    MagicResistance = 40,
                    CritRate = 5
                },
                new Hero()
                {
                    Id = 3,
                    Name = "Tiothya",
                    Role = "Support",
                    Health = 120,
                    AttackDamage = 10,
                    AbilityPower = 50,
                    Armor = 35,
                    MagicResistance = 25,
                    CritRate = 10
                },
            };

        return heroes;
        }
    }
}