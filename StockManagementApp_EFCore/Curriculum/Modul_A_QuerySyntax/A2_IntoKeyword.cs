using StockManagementApp_EFCore.Infrastructure;
using StockManagementApp_EFCore.Models;
using System;
using System.Linq;

namespace StockManagementApp_EFCore.Curriculum.Modul_A_QuerySyntax
{
    /// <summary>
    /// =========================================================================
    /// 📘 A2 — INTO (Query Continuation)
    /// =========================================================================
    /// 🎯 SORU SENARYOSU (Patronun Talebi):
    /// "Bana 2026 yılındaki tüm siparişleri müşteri bazında grupla. 
    ///  Ama sadece toplam cirosu 500.000 TL'den FAZLA olan müşterileri getir. 
    ///  Sonuçları da en yüksek cirodan en düşüğe doğru sırala."
    /// 
    /// 🧠 ANALİZ (Sen Neden `into` Kullanmalısın?):
    /// 1. Önce siparişleri müşteriye göre gruplamamız (GROUP BY) gerekiyor.
    /// 2. Grupladıktan sonra elde ettiğimiz "Toplam Ciro" değerine bir filtre 
    ///    uygulamamız (HAVING) gerekiyor. (Ciro > 500.000)
    /// 3. SQL'de WHERE, GROUP BY'dan ÖNCE; HAVING ise SONRA çalışır.
    /// LINQ'te ise bir `group by` sorgusunu filtrelemek için `into` kullanarak 
    /// sorguyu bir sonraki aşamaya (continuation) taşırız.
    /// 
    /// 🧠 TEKNİK NOT:
    /// `into` olmadan gruplanmış sonucu filtreleyemezsin. `into`, bir sorgunun
    /// sonucunu alıp yeni bir `from` (range variable) ile devam etmeni sağlar.
    /// EF Core bunu arka planda SQL `HAVING` cümleciğine çevirir.
    /// =========================================================================
    public class A2_IntoKeyword
    {
        public static void Run()
        {
            ConsoleLogger.Header("A2 — INTO KULLANIMI (Cirosu 500K'dan Yüksek Müşteriler)");

            using var db = AppDbContextFactory.Create(logSql: true);

            // LINQ Query Syntax + group by + into (query continuation)
            var sorgu = from so in db.SalesOrder
                        join c in db.Customer on so.CustomerId equals c.Id
                        join sol in db.SalesOrderLine on so.Id equals sol.SalesOrderId
                        where so.OrderDateUtc.Year == 2026 && so.Status != "Cancelled"
                        // 1. Aşama: Siparişleri müşteri bazında grupla
                        group sol by new { c.Id, c.Name } into grp
                        // 2. Aşama (into sonrası): Gruplanmış veriyi filtrele (HAVING)
                        where grp.Sum(x => x.LineTotal) > 500000m
                        // 3. Aşama: İstediğimiz formata dönüştür
                        orderby grp.Sum(x => x.LineTotal) descending
                        select new
                        {
                            MusteriId = grp.Key.Id,
                            MusteriAdi = grp.Key.Name,
                            SiparisSayisi = grp.Count(), // Grup içindeki sipariş satırı sayısı
                            ToplamCiro = grp.Sum(x => x.LineTotal)
                        };

            // Materialization (Sorguyu tetikle)
            var sonuclar = sorgu.ToList();

            if (!sonuclar.Any())
            {
                ConsoleLogger.Warning("Kriterlere uyan müşteri bulunamadı.");
                return;
            }

            ConsoleLogger.Success($"\nToplam {sonuclar.Count} müşteri bulundu (Cirosu > 500.000 TL):\n");
            Console.WriteLine($"{"Müşteri Adı",-45} | {"Sipariş Satırı",15} | {"Toplam Ciro",15}");
            Console.WriteLine(new string('-', 80));

            foreach (var s in sonuclar)
            {
                Console.WriteLine($"{s.MusteriAdi,-45} | {s.SiparisSayisi,15:N0} | {s.ToplamCiro,15:C2}");
            }
        }
    }
}

/**
       SELECT [c].[Id] AS [MusteriId], [c].[Name] AS [MusteriAdi], COUNT(*) AS [SiparisSayisi], COALESCE(SUM([s0].[LineTotal]), 0.0) AS [ToplamCiro]
      FROM [SalesOrder] AS [s]
      INNER JOIN [Customer] AS [c] ON [s].[CustomerId] = [c].[Id]
      INNER JOIN [SalesOrderLine] AS [s0] ON [s].[Id] = [s0].[SalesOrderId]
      WHERE DATEPART(year, [s].[OrderDateUtc]) = 2026 AND [s].[Status] <> N'Cancelled'  // c#  where so.OrderDateUtc.Year == 2026 && so.Status != "Cancelled"
      GROUP BY [c].[Id], [c].[Name]
      HAVING COALESCE(SUM([s0].[LineTotal]), 0.0) > 500000.0   // c#   where grp.Sum(x => x.LineTotal) > 500000m
      ORDER BY COALESCE(SUM([s0].[LineTotal]), 0.0) DESC
 */
/*
 
 sql having c# kodunda into keyword ile yapılır. into keyword ile sorgunun sonucunu alıp yeni bir from (range variable) ile devam etmeni sağlar.
 EF Core bunu arka planda SQL HAVING cümleciğine çevirir.
 */