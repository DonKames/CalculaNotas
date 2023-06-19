using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaNotas.Models
{
    internal class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public Professor Professor { get; set; }
        public ICollection<Grade> Grades { get; set; }
    }
}
