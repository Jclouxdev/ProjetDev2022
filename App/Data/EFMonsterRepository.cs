using App.Models;

namespace App.Data
{
    public class EFMonsterRepository : IRepository<Monster>
    {
        private readonly AppDbContext _dbContext;

        public EFMonsterRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Monster> GetAll()
        {
            return _dbContext.Monster.ToList();
        }

        public Monster GetById(int id)
        {
            return _dbContext.Monster.Single(r => r.Id == id);
        }

        public int Commit()
        {
            return _dbContext.SaveChanges();
        }

        public void Delete(Monster monster){
            _dbContext.Remove(monster);
        }
        public void Add(Monster monster){
            _dbContext.Add(monster);
        }
    }
}