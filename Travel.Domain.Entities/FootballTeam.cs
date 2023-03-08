using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace co.Travel.Domain.Entities
{
    public class FootballTeam : Entity
    {
        public string Name { get; set; }
        public int score { get; set; }
    }
}
