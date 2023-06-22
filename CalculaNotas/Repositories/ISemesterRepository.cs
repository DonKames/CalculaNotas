using CalculaNotas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaNotas.Repositories
{
    public interface ISemesterRepository
    {
        Task<Semester> GetSemesterById(int id);
        Task<List<Semester>> GetAllSemestersByCareerId(int id);
        Task<List<Semester>> GetAllSemesters();
        Task<Semester> AddSemester(Semester semester);
        Task<Semester> UpdateSemester(Semester semester);
        Task DeleteSemester(int id);
    }
}
