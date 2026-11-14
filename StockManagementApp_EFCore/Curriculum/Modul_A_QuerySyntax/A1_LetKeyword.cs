using StockManagementApp_EFCore.Infrastructure;
using StockManagementApp_EFCore.Models;
using System;
using System.Linq;

namespace StockManagementApp_EFCore.Curriculum.Modul_A_QuerySyntax
{
    /// <summary>
    /// =========================================================================
    /// 📘 A1 — LET KEYWORD (Query Syntax)
    /// =========================================================================
    /// 🎯 İŞ SENARYOSU: 
    /// Satış Müdürü, 2026 yılında kapatılmış (Closed) siparişlerin satırlarını 
    /// istiyor. Her satır için Brüt Tutar (Miktar x Fiyat) ve 
    /// Net Tutar (Brüt + KDV) hesaplanmalı. 
    /// Net Tutar > 10.000 TL ise "Yüksek Ciro" etiketi basılmalı.
    /// 
    /// 🧠 TEKNİK NOT:
    /// Klasik yöntemle (let'siz) aynı hesaplamayı (Miktar*Fiyat) SELECT, 
    /// WHERE ve ORDER BY içinde tekrar tekrar yazmak zorunda kalırsın.
    /// 
    /// `let` ile:
    /// 1. Hesaplamayı BİR KEZ yaparız.
    /// 2. Kod okunabilirliği artar.
    /// 3. SQL'e çevrilirken geçici bir "Alias" (Subquery/CTE) gibi davranır.
    /// 
    /// ⚠️ DİKKAT: `let` ifadesindeki değişkenler veritabanında fiziksel bir 
    /// kolon değildir. Sadece C# tarafında okunabilirlik için vardır. 
    /// =========================================================================
    public class A1_LetKeyword
    {
        public static void Run()
        {
            ConsoleLogger.Header("A1 — LET KULLANIMI (2026 Kapatılmış Sipariş Satırları)");

            using var db = AppDbContextFactory.Create(logSql: true);

            // LINQ Query Syntax + let kullanımı
            var sorgu = from sol in db.SalesOrderLine
                        join so in db.SalesOrder on sol.SalesOrderId equals so.Id
                        join tc in db.TaxCode on sol.TaxCodeId equals tc.Id
                        join pv in db.ProductVariant on sol.ProductVariantId equals pv.Id
                        join p in db.Product on pv.ProductId equals p.Id
                        where so.Status == "Closed"
                           && so.OrderDateUtc.Year == 2026
                        let brutTutar = sol.Quantity * sol.UnitPrice
                        let kdvOrani = tc.RatePercent / 100m
                        let netTutar = brutTutar * (1 + kdvOrani)
                        select new
                        {
                            UrunAdi = p.Name,
                            Miktar = sol.Quantity,
                            BrutTutar = brutTutar,
                            NetTutar = netTutar,
                            Etiket = netTutar > 10000 ? "Yüksek Ciro" : "Normal"
                        };

            // Sorguyu Tetikle (Materialization)
            var sonuclar = sorgu.Take(10).ToList(); // Ekranı doldurmasın diye Take(10)

            if (!sonuclar.Any())
            {
                ConsoleLogger.Warning("Kayıt bulunamadı.");
                return;
            }

            // Sonuçları Yazdır
            ConsoleLogger.Success($"\nToplam {sonuclar.Count} kayıt gösteriliyor:\n");
            foreach (var s in sonuclar)
            {
                Console.WriteLine($"Ürün: {s.UrunAdi,-30} | Miktar: {s.Miktar,3} | Brüt: {s.BrutTutar,10:C2} | Net: {s.NetTutar,10:C2} | Etiket: {s.Etiket}");
            }
        }
    }
}