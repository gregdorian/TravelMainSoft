using co.Travel.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace co.Travel.Application.AppServices
{
    public class EditorialAppService : IApplicationService<Editorial>
    {
        private readonly IApplicationService<Editorial> appEditorial;

        public EditorialAppService(IApplicationService<Editorial> appEditorial)
        {
            this.appEditorial = appEditorial;
        }
        public void Add(Editorial entity)
        {
            this.appEditorial.Add(entity);
        }

        public void Delete(int id)
        {
            this.appEditorial.Delete(id);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Editorial> GetAll()
        {
            return this.appEditorial.GetAll();
        }

        public Editorial GetById(int id)
        {
           return this.appEditorial.GetById(id);
        }

        public void Modify(Editorial entity)
        {
            this.appEditorial.Modify(entity);
        }
    }
}
