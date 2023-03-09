using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace co.Travel.Domain.Entities
{
    public class Libro : Entity
    {

        public int EditoresId { get; set; }

        public string Titulo { get; set; }

        public string Sinopsis { get; set; }

        public string NPaginas { get; set; }

        public virtual ICollection<AutoresLibro> AutoresLibros { get; } = new List<AutoresLibro>();

        public virtual Editorial Editores { get; set; }
    }
}
