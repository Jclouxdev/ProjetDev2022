using App.Models;
using Microsoft.EntityFrameworkCore;

namespace App.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Player> Player { get; set; }
        public DbSet<Monster> Monster { get; set; }
        public DbSet<Hero> Hero { get; set; }
        public DbSet<Dungeon> Dungeon { get; set;}
        public DbSet<Item> Item {get; set;}
        public DbSet<Drop> Drop {get; set;}
        public DbSet<Spell> Spell { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}