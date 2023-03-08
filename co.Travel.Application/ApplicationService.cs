

using co.Travel.Abstraction;
using co.Travel.Domain.Repository;

namespace co.Travel.Application
{
    public class ApplicationService<T> : IApplicationService<T> where T : IEntity
    {
        private readonly IRepositoryBase<T> _repository;

        public ApplicationService(IRepositoryBase<T> repository)
        {
            this._repository = repository;
        }
        public void Add(T entity)
        {
            _repository.Add(entity);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
           return _repository.GetAll();
        }

        public T GetById(int id)
        {
           return _repository.GetById(id);
        }

        public void Modify(T entity)
        {
            _repository.Modify(entity);
        }
    }
}
