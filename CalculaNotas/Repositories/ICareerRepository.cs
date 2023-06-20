using CalculaNotas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaNotas.Repositories
{
    public interface ICareerRepository
    {
        Task <Career> GetCareerById(int id);
        Task<List<Career>> GetAllCareers();
        Task<Career> AddCareer(Career career);
        Task<Career> UpdateCareer(Career newCareer);
        Task DeleteCareer(int id);
    }
}
