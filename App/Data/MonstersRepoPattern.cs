using System;
using App.Models;

namespace App.Data
{
    public class MonstersRepoPattern
    {
        public static List<Monster> GetAllMonsters() 
        {
            var monsters = new List<Monster>()
            {
                new Monster()
                {
                    Id = 1,
                    Name = "Crabix",
                    Role = "Dégats",
                    Health = 100,
                    AttackDamage = 50,
                    AbilityPower = 30,
                    Armor = 25,
                    MagicResistance = 25,
                    CritRate = 15,
                    AssetLink = "assets/cara/crab.gif"
                },
                new Monster()
                {
                    Id = 2,
                    Name = "Fantôme",
                    Role = "Support",
                    Health = 200,
                    AttackDamage = 20,
                    AbilityPower = 30,
                    Armor = 50,
                    MagicResistance = 40,
                    CritRate = 5,
                    AssetLink= "assets/cara/ghost.gif"
                },
                new Monster()
                {
                    Id = 3,
                    Name = "Orc",
                    Role = "Tank",
                    Health = 120,
                    AttackDamage = 10,
                    AbilityPower = 50,
                    Armor = 35,
                    MagicResistance = 25,
                    CritRate = 10,
                    AssetLink = "assets/cara/orc.gif"
                },
            };

        return monsters;
        }
    }
}