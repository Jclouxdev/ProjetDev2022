namespace App.Data
{
    public interface IRepository<TModel> where TModel : class
    {
        List<TModel> GetAll();

        TModel GetById(int id);

        int Commit();
    }
}