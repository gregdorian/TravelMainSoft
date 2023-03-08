using co.Travel.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace co.Travel.Domain.Repository
{
    public interface IRepositoryBase<T> : IAbstractionBase<T> where T : class
    {

    }
}
