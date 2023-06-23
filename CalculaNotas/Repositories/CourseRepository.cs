using CalculaNotas.Data;
using CalculaNotas.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaNotas.Repositories
{
    internal class CourseRepository : ICourseRepository
    {
        private readonly ApplicationDbContext _context;

        public CourseRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Course> AddCourse(Course course)
        {
            var result = await _context.Courses.AddAsync(course);
            await _context.SaveChangesAsync();
            return result.Entity;

            throw new NotImplementedException();
        }

        public Task DeleteCourse(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Course>> GetAllCourses()
        {
            throw new NotImplementedException();
        }

        public Task<List<Course>> GetAllCoursesBySemesterId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Course> GetCourseById(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCourse(Course course)
        {
            throw new NotImplementedException();
        }
    }
}
