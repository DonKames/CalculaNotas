using CalculaNotas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaNotas.Repositories
{
    internal interface ICourseRepository
    {
        Task<Course> GetCourseById(int id);
        Task<List<Course>> GetAllCourses();
        Task<List<Course>> GetAllCoursesBySemesterId(int id);
        Task<Course> AddCourse(Course course);
        Task UpdateCourse(Course course);
        Task DeleteCourse(int id);
    }
}
