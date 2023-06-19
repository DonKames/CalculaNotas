using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculaNotas.Models;

namespace CalculaNotas.Repositories
{
    internal interface IUserRepository
    {
        User GetUserById(int id);
        // Otros métodos necesarios para trabajar con los usuarios
    }
}
