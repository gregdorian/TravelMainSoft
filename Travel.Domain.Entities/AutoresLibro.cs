using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace co.Travel.Domain.Entities
{
    public class AutoresLibro
    {
        public int AutoresLibrosId { get; set; }

        public int? AutoresId { get; set; }

        public int? LibrosIsbn { get; set; }

        public virtual Autor Autores { get; set; }

        public virtual Libro LibroIsbn { get; set; }
    }
}
