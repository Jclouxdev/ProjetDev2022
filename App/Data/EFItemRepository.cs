using App.Models;

namespace App.Data
{
    public class EFItemRepository : IRepository<Item>
    {
        private readonly AppDbContext _dbContext;

        public EFItemRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Item> GetAll()
        {
            return _dbContext.Item.ToList();
        }

        public Item GetById(int id)
        {
            return _dbContext.Item.Single(r => r.Id == id);
        }

        public int Commit()
        {
            return _dbContext.SaveChanges();
        }

        public void Delete(Item item){
            _dbContext.Remove(item);
        }
        public void Add(Item item){
            _dbContext.Add(item);
        }
    }
}