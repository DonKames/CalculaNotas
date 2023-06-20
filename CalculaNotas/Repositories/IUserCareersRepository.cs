using CalculaNotas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaNotas.Repositories
{
    public interface IUserCareersRepository
    {
        Task<UserCareer> GetUserCareerById(int id);
        Task<List<UserCareer>> GetAllUserCareers();
        Task<UserCareer> AddUserCareer(UserCareer career);
        Task<UserCareer> UpdateUserCareer(UserCareer career);
        Task DeleteUserCareer(int id);
    }
}
