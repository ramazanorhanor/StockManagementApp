using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class VwAnlamliVeriTesti
{
    public string UrunAdi { get; set; } = null!;

    public int? ToplamSatisAdedi { get; set; }

    public decimal? ToplamCiro { get; set; }
}
