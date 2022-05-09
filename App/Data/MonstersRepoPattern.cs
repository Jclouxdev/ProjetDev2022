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
                    Name = "Pruxyne",
                    Role = "Dégats",
                    Health = 100,
                    AttackDamage = 50,
                    AbilityPower = 30,
                    Armor = 25,
                    MagicResistance = 25,
                    CritRate = 15,
                    AssetLink = "assets/cara/dps-human.gif"
                },
                new Monster()
                {
                    Id = 2,
                    Name = "Kleomasose",
                    Role = "Tank",
                    Health = 200,
                    AttackDamage = 20,
                    AbilityPower = 30,
                    Armor = 50,
                    MagicResistance = 40,
                    CritRate = 5,
                    AssetLink= "assets/cara/tank-human.gif"
                },
                new Monster()
                {
                    Id = 3,
                    Name = "Tiothya",
                    Role = "Support",
                    Health = 120,
                    AttackDamage = 10,
                    AbilityPower = 50,
                    Armor = 35,
                    MagicResistance = 25,
                    CritRate = 10,
                    AssetLink = "assets/cara/healer-fairy.gif"
                },
            };

        return monsters;
        }
    }
}