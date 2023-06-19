using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CalculaNotas.Models;

namespace CalculaNotas.Data
{
    internal class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=CalculaNotas.db");
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Career> Careers { get; set; }
        public DbSet<Semester> Semesters { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Professor> Professors { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<UserCareer> UserCareers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Career>().ToTable("Careers");
            modelBuilder.Entity<Semester>().ToTable("Semesters");
            modelBuilder.Entity<Course>().ToTable("Courses");
            modelBuilder.Entity<Professor>().ToTable("Professors");
            modelBuilder.Entity<Grade>().ToTable("Grades");

            modelBuilder.Entity<UserCareer>()
        .HasKey(uc => new { uc.UserId, uc.CareerId }); // Establece las propiedades que componen la clave primaria de la entidad

            modelBuilder.Entity<UserCareer>()
                .HasOne(uc => uc.User)
                .WithMany(u => u.UserCareers)
                .HasForeignKey(uc => uc.UserId); // Configura la relación desde User a UserCareer

            modelBuilder.Entity<UserCareer>()
                .HasOne(uc => uc.Career)
                .WithMany(c => c.UserCareers)
                .HasForeignKey(uc => uc.CareerId); // Configura la relación desde Career a UserCareer
        }
    }
}
