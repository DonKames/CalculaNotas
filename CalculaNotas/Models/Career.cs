using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CalculaNotas.Models
{
    public class Career
    {
        public int CareerId { get; set; }

        [Required(ErrorMessage = "El campo Name es requerido")]
        public string Name { get; set; }

        public ICollection<Semester> Semesters { get; set; }

        public ICollection<UserCareer> UserCareers { get; set; }

    }
}
