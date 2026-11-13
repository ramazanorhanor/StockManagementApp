using System;
using System.Linq;


namespace StockManagementApp_EF6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== EF 6.2 VERİTABANI BAĞLANTI TESTİ ===");

            using (var db = new StockManagementERPEntities())
            {
                // EF 6.2 SQL Loglaması
                db.Database.Log = s => Console.WriteLine(s);

                var aktifUrunler = db.Products
                                      .Where(p => p.IsActive)
                                      .Take(3)
                                      .ToList();

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
                    Console.WriteLine("Hiç ürün bulunamadı.");
                }
            }

            Console.WriteLine("\nProgram bitti. Çıkmak için bir tuşa bas...");
            Console.ReadKey();
        }
    }
}