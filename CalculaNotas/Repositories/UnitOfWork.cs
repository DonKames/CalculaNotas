using CalculaNotas.Data;
using CalculaNotas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaNotas.Repositories
{
    internal class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _dbContext;
        public ICareerRepository Careers { get; set; }
        public ISemesterRepository Semesters { get; set; }
        public IUserRepository Users { get; set; }
        public IUserCareersRepository UserCareers { get; set; }
        public ICourseRepository Courses { get; set; }

        public UnitOfWork(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            Careers = new CareerRepository(_dbContext);
            Courses = new CourseRepository(_dbContext);
            Semesters = new SemesterRepository(_dbContext);
            Users = new UserRepository(_dbContext);
            UserCareers = new UserCareerRepository(_dbContext);
        }

        public int Complete()
        {
            return _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }


    }
}
