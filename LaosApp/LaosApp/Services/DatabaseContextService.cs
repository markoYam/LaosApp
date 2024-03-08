using LaosApp.Models;
using LaosApp.Views;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppTest.Services
{
    public class DatabaseContextService : DbContext
    {
        private const string _dbName = "laosapp.db";
        private static string DbPath
        {
            get
            {
                //validate if ios
                string? currentPath;
                if (DeviceInfo.Platform == DevicePlatform.iOS)
                {
                    currentPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                }
                else
                {
                    currentPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                }

                return Path.Combine(currentPath, _dbName);
            }
        }

        //agregar listado de modelos
        //public DbSet<LoginModel> Users { get; set; } = null!;

        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={DbPath}");
            optionsBuilder.EnableSensitiveDataLogging();
        }
    }
}
