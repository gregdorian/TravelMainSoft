using co.Travel.Abstraction;
using co.Travel.Domain.Entities;
using co.Travel.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace co.Travel.Domain.Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class, IEntity
    {
        private readonly TravelDbContext _ctx;

        public RepositoryBase(TravelDbContext ctx) {
            _ctx = ctx;
        }

        public void Add(T entity)
        {
            try
            {

                _ctx.Set<T>().Add(entity);
                _ctx.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("No se puede guardar el registro", ex);
            }
        }

        public void Delete(int id)
        {
            try
            {
                var entity = _ctx.Set<T>().Find(id);
                if (entity != null)
                {
                    _ctx.Set<T>().Remove(entity);
                    _ctx.SaveChanges();
                }


            }
            catch (Exception ex)
            {
                throw new Exception("No se puede eliminar el registro", ex);
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            try
            {
                 return _ctx.Set<T>().ToList();               
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudieron recuperar los registros", ex);
            }
        }

        public T GetById(int id)
        {
            try
            {

                var entity = _ctx.Set<T>().FirstOrDefault(e => e.Id == id);
                if(entity != null ) {
                    return entity;
                }  else
                {
                    return null;  // 
                }
                
 
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo recuperar el registro", ex);
            }
        }

        public void Modify(T entity)
        {
            try
            {
                    _ctx.Entry(entity).State = EntityState.Modified;
                    _ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("No se puede actualizar el registro", ex);
            }
        }
    }

}
