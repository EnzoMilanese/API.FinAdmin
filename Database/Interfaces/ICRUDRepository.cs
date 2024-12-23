using Domain.Entities;

namespace Database.Interfaces
{
    public interface ICRUDRepository<T> where T : Entity
    {
        public T Create(T entity);
        public T? Get(int id);
        public IEnumerable<T> Get();
        public T? Remove(int id);
        public T Update(T entity);
    }
}
