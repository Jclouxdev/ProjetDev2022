namespace App.Data
{
    public interface IPlayerRepository<TModel> where TModel : class
    {
        List<TModel> GetAll();

        TModel GetById(int id);

        TModel Add(TModel model);
        TModel GetByFirstName(string name);
        TModel GetByMail(string mail);
        bool AnyMail(string mail);
        int Commit();
    }
}