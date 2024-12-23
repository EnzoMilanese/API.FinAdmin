using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Database.Repositories
{
    public class BaseRepository<T> where T : Entity
    {
        private readonly DbContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public BaseRepository(Context dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }

        public virtual T Create(T entity)
        {
            entity = _dbSet.Add(entity).Entity;
            _dbContext.SaveChanges();
            return entity;
        }

        public virtual T? Get(int id) => _dbSet.SingleOrDefault(e => e.Id == id);

        public virtual IEnumerable<T> Get() => _dbSet.Where(e => e.Status);

        public virtual T Update(T entity)
        {
            entity = _dbSet.Update(entity).Entity;
            _dbContext.SaveChanges();
            return entity;
        }

        public virtual T? Remove(int id)
        {
            var entity = Get(id);
            if (entity != null)
            {
                entity.Status = false;
                entity = _dbSet.Update(entity).Entity;
                _dbContext.SaveChanges();
                return entity;
            }

            return default;
        }
    }
}
