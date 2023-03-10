using co.Travel.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace co.Travel.Application.AppServices
{
    public class LibroAppService : IApplicationService<Libro>
    {
        private readonly IApplicationService<Libro> appLibro;

        public LibroAppService(IApplicationService<Libro> AppLibro)
        {
            appLibro = AppLibro;
        }

        public void Add(Libro entity)
        {
            appLibro.Add(entity);
        }

        public void Delete(int id)
        {
            appLibro.Delete(id);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Libro> GetAll()
        {
          return appLibro.GetAll();
        }

        public Libro GetById(int id)
        {
            return appLibro.GetById(id);
        }

        public void Modify(Libro entity)
        {
            appLibro.Modify(entity);
        }
    }
}
