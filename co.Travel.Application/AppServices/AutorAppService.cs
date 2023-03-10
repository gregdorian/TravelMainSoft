using co.Travel.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace co.Travel.Application.AppServices
{
    public class AutorAppService : IApplicationService<Autor>
    {
        private readonly IApplicationService<Autor> appAutor;

        public AutorAppService(IApplicationService<Autor> appAutor)
        {
            this.appAutor = appAutor;
        }
        public void Add(Autor entity)
        {
            this.appAutor.Add(entity);
        }

        public void Delete(int id)
        {
            this.appAutor.Delete(id);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Autor> GetAll()
        {
            return this.appAutor.GetAll();
        }

        public Autor GetById(int id)
        {
            return this.appAutor.GetById(id);
        }

        public void Modify(Autor entity)
        {
             this.appAutor.Modify(entity);
        }
    }
}
