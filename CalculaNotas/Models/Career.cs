﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaNotas.Models
{
    public class Career
    {
        public int CareerId { get; set; }
        public string Name { get; set; }
        public ICollection<Semester> Semesters { get; set; }
        public ICollection<UserCareer> UserCareers { get; set; }
    }
}
