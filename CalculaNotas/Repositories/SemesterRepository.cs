using CalculaNotas.Data;
using CalculaNotas.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaNotas.Repositories
{
    internal class SemesterRepository : ISemesterRepository
    {
        private readonly ApplicationDbContext _context;

        public SemesterRepository(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<Semester?> GetSemesterById(int id)
        {
            return await _context.Semesters.FindAsync(id);
        }

        public async Task<List<Semester>> GetAllSemestersByCareerId(int id)
        {
            var career = await _context.Careers.Include(c => c.Semesters).FirstOrDefaultAsync(c => c.CareerId == id);
            return career?.Semesters.ToList();
        }

        public async Task<List<Semester>> GetAllSemesters()
        {
            return await _context.Semesters.ToListAsync();
        }

        public async Task<Semester> AddSemester(Semester semester)
        {
            var result = await _context.Semesters.AddAsync(semester);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Semester> UpdateSemester(Semester semester)
        {
            _context.Entry(semester).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return semester;
        }

        public async Task DeleteSemester(int id)
        {
            var semester = await _context.Semesters.FindAsync(id);
            if (semester != null)
            {
                _context.Semesters.Remove(semester);
                await _context.SaveChangesAsync();
            }
        }
    }
}
