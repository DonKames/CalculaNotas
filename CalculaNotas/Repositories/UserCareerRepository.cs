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
    internal class UserCareerRepository : IUserCareersRepository
    {
        private readonly ApplicationDbContext _context;

        public UserCareerRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<UserCareer?> GetUserCareerById(int id)
        {
            return await _context.UserCareers.FindAsync(id);
        }

        public async Task<List<UserCareer>> GetAllUserCareers()
        {
            return await _context.UserCareers.ToListAsync();
        }

        public async Task<UserCareer> AddUserCareer(UserCareer userCareer)
        {
            var result = await _context.UserCareers.AddAsync(userCareer);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<UserCareer> UpdateUserCareer(UserCareer userCareer)
        {
            _context.Entry(userCareer).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return userCareer;
        }

        public async Task DeleteUserCareer(int id)
        {
            var userCareer = await _context.UserCareers.FindAsync(id);
            if (userCareer != null)
            {
                _context.UserCareers.Remove(userCareer);
                await _context.SaveChangesAsync();
            }
        }
    }
}
