namespace WebAPI.Constracts
{
    public interface ICrud <T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetByID(int id);
        T Add(T entity);
        T Update(T entity);
        T Delete(T entity);
    }
}
