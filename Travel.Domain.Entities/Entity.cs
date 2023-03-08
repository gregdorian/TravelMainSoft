using co.Travel.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace co.Travel.Domain.Entities
{
    public abstract class Entity  : IEntity
    {
        public int Id { get; set; }
        //public DateTime FechaCreacion { get; set; }
        //public DateTime FechaModificacion { get; set;}
    }
}
