namespace LibraryProject.DataBase.Repositories.Abstracts;

public interface IRepository<T>
{
    T? GetById(int id);
    void Add(T entity);
    void AddRange(ICollection<T> entities);
    ICollection<T> GetAll();
    void Remove(T entity);
    void Remove(int id);
    void Update(T entity);
    void SaveChanges();

}
