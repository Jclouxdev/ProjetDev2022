using App.Models;

namespace App.Data
{
    public class EFDungeonRepository : IRepository<Dungeon>
    {
        private readonly AppDbContext _dbContext;

        public EFDungeonRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Dungeon> GetAll()
        {
            return _dbContext.Dungeon.ToList();
        }

        public Dungeon GetById(int id)
        {
            return _dbContext.Dungeon.Single(r => r.Id == id);
        }
        public int Commit()
        {
            return _dbContext.SaveChanges();
        }

        public void Delete(Dungeon dungeon){
            _dbContext.Remove(dungeon);
        }
    }
}