using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace co.Travel.Domain.Entities
{
    public class Autor
    {
        public int Id { get; set; }

        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public virtual ICollection<AutoresLibro> AutoresLibros { get; } = new List<AutoresLibro>();
    }
}
