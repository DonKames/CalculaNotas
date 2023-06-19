using System;
using CalculaNotas.Data;
using Microsoft.EntityFrameworkCore;

namespace CalculaNotas
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            using (var db = new ApplicationDbContext())
            {
                db.Database.Migrate();
            }

            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}