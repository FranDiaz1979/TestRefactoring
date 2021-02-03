namespace TestRefactoring.Data
{
    using System.Linq;

    internal class Repository<T> : IRepository<T> where T : class
    {
        public void Add(T entity)
        {
            // DBContext.Set<T>.Add(entity);
            throw new System.NotImplementedException();
        }

        public void Delete(T entity)
        {
            // DBContext.Set<T>.Delete(entity);
            throw new System.NotImplementedException();
        }

        public IQueryable<T> GetAll()
        {
            // return DBContext.Set<T>.ToQueryable();
            throw new System.NotImplementedException();
        }

        public void Update(T entity)
        {
            // DBContext.Set<T>.Update(entity);
            throw new System.NotImplementedException();
        }
    }
}