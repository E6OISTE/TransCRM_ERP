namespace TransCRM_ERP.API
{
    public interface IRepository<T> : IDisposable
        where T : class
    {
        IEnumerable<T> GetList();
        T Get(Guid Id);
        void Create(T entity);
        void Update(T entity);
        void Delete(Guid id);
        void DeleteAll();
        void Save();
    }
}
