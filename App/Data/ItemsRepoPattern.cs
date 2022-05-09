using System;
using App.Models;

namespace App.Data
{
    public class ItemsRepoPattern
    {
        public static List<Item> GetAllItems() 
        {
            var items = new List<Item>()
            {
                new Item()
                {
                    Id = 1,
                    Name = "Devine",
                    Type = "Epée",
                    Damage = 200,
                    Description = "Devine est une épée légendaire qui permet de découper ses ennemis",
                    Effect = "+ 10 attaque",
                    AssetLink = "assets/items/devine.png"
                },
                new Item()
                {
                    Id = 2,
                    Name = "Tranquility",
                    Type = "Sceptre",
                    Damage = 50,
                    Description = "Sceptre qui permet à l'utilisateur de soigner ses alliés",
                    Effect = "+ 5 soins",
                    AssetLink= "assets/items/tranquility.png"
                },
                new Item()
                {
                    Id = 3,
                    Name = "Loyalty",
                    Type = "Epée",
                    Damage = 100,
                    Description = "",
                    Effect = "+ 5% de crit",
                    AssetLink = "assets/items/loyalty.png"
                },
                new Item()
                {
                    Id = 4,
                    Name = "Shield",
                    Type = "Bouclier",
                    Damage = 50,
                    Description = "",
                    Effect = "+ 20 de resistance",
                    AssetLink = "assets/items/shield.png"
                },
                new Item()
                {
                    Id = 5,
                    Name = "Axe",
                    Type = "Hache",
                    Damage = 100,
                    Description = "",
                    Effect = "+ 50 de vie",
                    AssetLink = "assets/items/axe.png"
                },

            };

        return items;
        }
    }
} 
