using Database.Contexts;
using LibraryProject.DataBase.Repositories.Abstracts;
using Microsoft.EntityFrameworkCore;
using Models.Interfaces;


namespace Database.Repositories.Concretes
{
    public class Repository<T> : IRepository<T> where T : class, IId
    {
        private readonly LibraryDbContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository()
        {
            _context = new LibraryDbContext();
            _dbSet = _context.Set<T>();
        }

        public void Add(T entity)
        {
            if (entity == null) throw new Exception("Data is null");
            _dbSet.Add(entity);
        }

        public void AddRange(ICollection<T> entities)
        {
            if (entities == null || entities.Count == 0) throw new Exception("Data is null");
            _dbSet.AddRange(entities);
        }

        public ICollection<T> GetAll()
        {
            return _dbSet.ToList<T>();
        }


        public T? GetById(int id)
        {
            return _dbSet.FirstOrDefault(p => p.Id == id);
        }

        public void Remove(T entity)
        {
            var en = _dbSet.FirstOrDefault(p => p.Id == entity.Id);
            if (en == null) throw new Exception("Data is null");

            _dbSet.Remove(entity);
        }

        public void Remove(int id)
        {
            var entity = _dbSet.FirstOrDefault(p => p.Equals(id));
            if (entity == null) throw new Exception("Data is null");

            _dbSet.Remove(entity);
        }
        public void Update(T entity)
        {
            var en = _dbSet.FirstOrDefault(p => p.Id == entity.Id);
            if (en == null) throw new Exception("Data is null");
            _dbSet.Update(entity);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }


    }

}
