using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace co.Travel.Abstraction
{
    public interface IAbstractionBase<T> where T : class
    {
        void Add(T entity);

        void Delete(int id);

        void Modify(T entity);

        IEnumerable<T> GetAll();

        T GetById(int id);

        void Dispose();
    }
}
