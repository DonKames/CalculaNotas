using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculaNotas.Models;

namespace CalculaNotas.Repositories
{
    public interface IUserRepository
    {
        // User GetUserById(int id);
        // Otros métodos necesarios para trabajar con los usuarios

        Task<User> GetUserById(int id);
        Task<List<User>> GetAllUsers();
        Task<User> AddUser(User user);
        Task<User> UpdateUser(User user);
        Task DeleteUser(int id);
    }
}
