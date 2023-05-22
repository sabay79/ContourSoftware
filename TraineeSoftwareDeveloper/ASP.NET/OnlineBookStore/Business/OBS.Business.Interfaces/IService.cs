namespace OBS.Business.Interfaces
{
    public interface IService<TModel>
    {
        List<TModel> GetAll();
        TModel GetByID(int id);
        void Add(TModel model);
        void Update(TModel model);
        void Delete(int id);
    }
}