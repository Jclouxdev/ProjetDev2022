using System;
using App.Models;

namespace App.Data
{
    public class EFShopRepository : IRepository<ShopItem>
    {
        private readonly AppDbContext _dbContext;

        public EFShopRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<ShopItem> GetAll()
        {
            return _dbContext.ShopItem.ToList();
        }

        public ShopItem GetById(int id)
        {
            return _dbContext.ShopItem.Single(r => r.ShopItemId == id);
        }

        public int Commit()
        {
            return _dbContext.SaveChanges();
        }

        public void Delete(ShopItem shopItem){
            _dbContext.Remove(shopItem);
        }
        public void Add(ShopItem shopItem){
            _dbContext.Add(shopItem);
        }
    }
}