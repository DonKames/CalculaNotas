using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaNotas.Models
{
    public class Semester
    {
        public int SemesterId { get; set; }
        public string Name { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
