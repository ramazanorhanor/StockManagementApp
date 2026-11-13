using Microsoft.EntityFrameworkCore;
using StockManagementApp_EFCore.Models;
using System;
using System.Linq;

namespace StockManagementApp_EFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Bağlantı Cümlesi (Connection String)
            // Not: Scaffold komutunda kullandığımız aynı bağlantı.
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=StockManagementERP;Trusted_Connection=True;TrustServerCertificate=True;";

            // 2. DbContext Ayarları (Options)
            var optionsBuilder = new DbContextOptionsBuilder<StockManagementDbContext>();
            optionsBuilder.UseSqlServer(connectionString)
                          .LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information);
            // LogTo: Arka planda üretilen SQL'i konsola yazdırır!

            // 3. DbContext Örneği
            using var db = new StockManagementDbContext(optionsBuilder.Options);

            Console.WriteLine("=== VERİTABANI BAĞLANTI TESTİ ===");

            // 4. Basit Sorgu
            var aktifUrunler = db.Product
                                  .Where(p => p.IsActive)
                                  .Take(3)
                                  .ToList();

            // 5. Sonuçları Yazdır
            if (aktifUrunler.Any())
            {
                Console.WriteLine("\n=== İLK 3 AKTİF ÜRÜN ===");
                foreach (var urun in aktifUrunler)
                {
                    Console.WriteLine($"ID: {urun.Id} | SKU: {urun.BaseSku} | Ad: {urun.Name}");
                }
            }
            else
            {
                Console.WriteLine("Hiç ürün bulunamadı. Tablo boş olabilir.");
            }

            Console.WriteLine("\nProgram bitti. Çıkmak için bir tuşa bas...");
            Console.ReadKey();
        }
    }
}