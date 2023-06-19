using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaNotas.Models
{
    internal class Career
    {
        public int CareerId { get; set; }
        public string Name { get; set; }
        public ICollection<Semester> Semesters { get; set; }
    }
}
