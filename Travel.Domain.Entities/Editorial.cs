using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace co.Travel.Domain.Entities
{
    public class Editorial : Entity
    {

        public string Sede { get; set; }

        public virtual ICollection<Libro> Libros { get; } = new List<Libro>();
    }
}
