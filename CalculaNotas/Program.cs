using System;
using Autofac;
using CalculaNotas.Data;
using CalculaNotas.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CalculaNotas
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        private static IContainer Container { get; set; }

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            RegisterServices();

            using (var db = new ApplicationDbContext())
            {
                db.Database.Migrate();
            }

            ApplicationConfiguration.Initialize();

            using (var scope = Container.BeginLifetimeScope())
            {
                var mainForm = scope.Resolve<MainForm>();

                Application.Run(mainForm);
            }
        }

        private static void RegisterServices()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<ApplicationDbContext>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<UserRepository>().As<IUserRepository>();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
            builder.RegisterType<MainForm>();

            Container = builder.Build();
        }
    }
}