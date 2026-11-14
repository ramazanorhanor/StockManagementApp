using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using StockManagementApp_EFCore.Models;
using System;

namespace StockManagementApp_EFCore.Infrastructure
{
    /// <summary>
    /// Tech Lead Notu: DbContext'i her sorguda 'new'lemek yerine 
    /// Factory Pattern ile tek merkezden üretiyoruz. 
    /// LogTo() sayesinde arka planda üretilen SQL'i konsola dökeriz.
    /// </summary>
    public static class AppDbContextFactory
    {
        private static readonly string ConnectionString =
            "Server=(localdb)\\mssqllocaldb;Database=StockManagementERP;Trusted_Connection=True;TrustServerCertificate=True;";

        public static StockManagementDbContext Create(bool logSql = true)
        {
            var optionsBuilder = new DbContextOptionsBuilder<StockManagementDbContext>();

            optionsBuilder.UseSqlServer(ConnectionString);

            if (logSql)
            {
                // Sadece Information seviyesindeki SQL loglarını göster
                optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information)
                              .EnableSensitiveDataLogging(); // Parametreleri de göster (Dikkat: Prod'da kapatılır!)
            }

            return new StockManagementDbContext(optionsBuilder.Options);
        }
    }
}