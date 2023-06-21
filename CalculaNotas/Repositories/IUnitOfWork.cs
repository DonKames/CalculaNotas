using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaNotas.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        ICareerRepository Careers { get; }
        ISemesterRepository Semesters { get; }
        IUserRepository Users { get; }
        IUserCareersRepository UserCareers { get; }

        int Complete();
    }
}
