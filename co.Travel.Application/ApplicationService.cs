

namespace co.Travel.Application
{
    public class ApplicationService<T> : IApplicationService<T> where T : class
    {
        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Modify(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
