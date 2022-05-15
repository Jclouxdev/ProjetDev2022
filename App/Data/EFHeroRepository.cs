using App.Models;

namespace App.Data
{
    public class EFHeroRepository : IRepository<Hero>
    {
        private readonly AppDbContext _dbContext;

        public EFHeroRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Hero> GetAll()
        {
            return _dbContext.Hero.ToList();
        }

        public Hero GetById(int id)
        {
            return _dbContext.Hero.Single(r => r.Id == id);
        }

        public int Commit()
        {
            return _dbContext.SaveChanges();
        }

        public void Delete(Hero hero){
            _dbContext.Remove(hero);
        }
    }
}