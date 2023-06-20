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
    internal class CareerRepository : ICareerRepository
    {
        private readonly ApplicationDbContext _context;

        public CareerRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Career> AddCareer(Career career)
        {
            var result = await _context.Careers.AddAsync(career);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public Task DeleteCareer(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Career>> GetAllCareers()
        {
            return await _context.Careers.ToListAsync();
        }

        public async Task<Career> GetCareerById(int id)
        {
            return await _context.Careers.FindAsync(id);
        }

        public Task<Career> UpdateCareer(Career newCareer)
        {
            throw new NotImplementedException();
        }
    }
}
