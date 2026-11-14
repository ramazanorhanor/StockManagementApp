//using Microsoft.EntityFrameworkCore;
//using StockManagementApp_EFCore.Models;
//using System;
//using System.Linq;

//namespace StockManagementApp_EFCore
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // 1. Bağlantı Cümlesi (Connection String)
//            // Not: Scaffold komutunda kullandığımız aynı bağlantı.
//            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=StockManagementERP;Trusted_Connection=True;TrustServerCertificate=True;";

//            // 2. DbContext Ayarları (Options)
//            var optionsBuilder = new DbContextOptionsBuilder<StockManagementDbContext>();
//            optionsBuilder.UseSqlServer(connectionString)
//                          .LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information);
//            // LogTo: Arka planda üretilen SQL'i konsola yazdırır!

//            // 3. DbContext Örneği
//            using var db = new StockManagementDbContext(optionsBuilder.Options);

//            Console.WriteLine("=== VERİTABANI BAĞLANTI TESTİ ===");

//            // 4. Basit Sorgu
//            var aktifUrunler = db.Product
//                                  .Where(p => p.IsActive)
//                                  .Take(3)
//                                  .ToList();

//            // 5. Sonuçları Yazdır
//            if (aktifUrunler.Any())
//            {
//                Console.WriteLine("\n=== İLK 3 AKTİF ÜRÜN ===");
//                foreach (var urun in aktifUrunler)
//                {
//                    Console.WriteLine($"ID: {urun.Id} | SKU: {urun.BaseSku} | Ad: {urun.Name}");
//                }
//            }
//            else
//            {
//                Console.WriteLine("Hiç ürün bulunamadı. Tablo boş olabilir.");
//            }

//            Console.WriteLine("\nProgram bitti. Çıkmak için bir tuşa bas...");
//            Console.ReadKey();
//        }
//    }
//}

using StockManagementApp_EFCore.Curriculum.Modul_A_QuerySyntax;
using System;

namespace StockManagementApp_EFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("==================================================");
                Console.WriteLine("  📚 STOCKMANAGEMENTERP - LINQ MASTER CURRICULUM");
                Console.WriteLine("==================================================");
                Console.WriteLine("  [A1] Let Keyword Kullanımı (Modül A)");
                Console.WriteLine("  [Q]  Çıkış");
                Console.WriteLine("==================================================");
                Console.Write("\nModül Seçiniz: ");

                var secim = Console.ReadLine()?.Trim().ToUpper();

                Console.Clear();

                switch (secim)
                {
                    case "A1":
                        A1_LetKeyword.Run();
                        break;
                    case "Q":
                        return;
                    default:
                        Console.WriteLine("Geçersiz seçim. Devam etmek için bir tuşa basın...");
                        break;
                }

                Console.WriteLine("\nDevam etmek için bir tuşa basın...");
                Console.ReadKey();
            }
        }
    }
}