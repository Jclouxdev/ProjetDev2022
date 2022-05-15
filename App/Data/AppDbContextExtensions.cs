using App.Models;

namespace App.Data;
public static class AppDbContextExtensions
{
    public static void SeedPlayer(this AppDbContext dbContext)
    {
        if (!dbContext.Player.Any()){
            var players = new List<Player>()
            {
                new Player()
                {
                    Id = 1,
                    Name = "admin",
                    Password = "1JbyJVbugGEUUcyhC30HQzYpg+mKw9ictnskQ5kj3xk=",
                    Email = "admin@gmail.com",
                    Salt = "CYF+xPkgW5cd6RomOz/ZMfcfriIynxtrkZwNFIz+uT0=",
                    CreationDate = DateTime.Now
                },
                new Player()
                {
                    Id = 2,
                    Name = "player",
                    Password = "KMkHYbtVl7chMP8iGx23/JwB6K1RFr6KTr06TewcgQ4=",
                    Email = "player@gmail.com",
                    Salt = "+XGMpKDHVVH1vm+bSxtYQeeXoydK4HL9gXShxGda/S8=",
                    CreationDate = DateTime.Now
                }
            };
            dbContext.Player.AddRange(players);
            dbContext.SaveChanges();
        }
    }

    public static void SeedHero(this AppDbContext dbContext)
    {
        if (!dbContext.Hero.Any()){
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
                    CritRate = 15,
                    AssetLink = "assets/cara/dps-human.gif"
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
                    CritRate = 5,
                    AssetLink= "assets/cara/tank-human.gif"
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
                    CritRate = 10,
                    AssetLink = "assets/cara/healer-fairy.gif"
                }
            };
            dbContext.Hero.AddRange(heroes);
            dbContext.SaveChanges();
        }
    }

    public static void SeedMonster(this AppDbContext dbContext)
    {
        if (!dbContext.Monster.Any()){
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
            dbContext.Monster.AddRange(monsters);
            dbContext.SaveChanges();
        }
    }

     public static void SeedSpell(this AppDbContext dbContext)
    {
        if (!dbContext.Spell.Any()){
            var spells = new List<Spell>()
            {
                new Spell()
                {
                    Id = 1,
                    Name = "Ice",
                    Cost = 10,
                    Physical = 0,
                    Magical = 50,
                    AssetLink = "assets/spells/ice.png"
                },
                new Spell()
                {
                    Id = 2,
                    Name = "Fire",
                    Cost = 15,
                    Physical = 0,
                    Magical = 55,
                    AssetLink= "assets/spells/fire.png"
                },
                new Spell()
                {
                    Id = 3,
                    Name = "Wind",
                    Cost = 10,
                    Physical = 0,
                    Magical = 45,
                    AssetLink = "assets/spells/wind.png"
                },
            };
            dbContext.Spell.AddRange(spells);
            dbContext.SaveChanges();
        }
    }
}