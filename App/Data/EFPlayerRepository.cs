using App.Models;

namespace App.Data
{
    public class EFPlayerRepository : IPlayerRepository<Player>
    {
        private readonly AppDbContext _dbContext;

        public EFPlayerRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

         public List<Player> GetAll()
        {
            return _dbContext.Player.ToList();
        }

        public Player GetById(int id)
        {
            return _dbContext.Player.Single(r => r.Id == id);
        }

        public int Commit()
        {
            return _dbContext.SaveChanges();
        }
        public Player Add(Player model){
            return _dbContext.Player.Add(model).Entity;
        }
        public Player GetByMail(string mail){
            return _dbContext.Player.Single(r => r.Email == mail);
        }
        public Player GetByUname(string uname){
            return _dbContext.Player.Single(r => r.Name == uname);
        }
        public bool AnyMail(string mail){
            return _dbContext.Player.Any(r => r.Email == mail);
        }
        public bool AnyName(string name){
            return _dbContext.Player.Any(r => r.Name == name);
        }
    }
}