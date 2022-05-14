namespace App.Data
{
    public interface IPlayerRepository<TModel> where TModel : class
    {
        public List<TModel> GetAll();
        public TModel GetById(int id);
        public int Commit();
        public TModel Add(TModel model);
        public TModel GetByMail(string mail);
        public TModel GetByUname(string uname);
        public bool AnyMail(string mail);
        public bool AnyName(string name);

    }
}