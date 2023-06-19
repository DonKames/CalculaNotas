using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaNotas.Models
{
    public class UserCareer
    {
        public int UserId { get; set; }
        public User User { get; set; }

        public int CareerId { get; set; }
        public Career Career { get; set; }
    }
}
