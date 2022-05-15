using App.Models;

namespace App.Data
{
    public class EFSpellRepository : IRepository<Spell>
    {
        private readonly AppDbContext _dbContext;

        public EFSpellRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Spell> GetAll()
        {
            return _dbContext.Spell.ToList();
        }

        public Spell GetById(int id)
        {
            return _dbContext.Spell.Single(r => r.Id == id);
        }

        public int Commit()
        {
            return _dbContext.SaveChanges();
        }
    }
}