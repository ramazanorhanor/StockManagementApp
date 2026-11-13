using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class VwKritiktablolarinSatirSayilari
{
    public string Tablo { get; set; } = null!;

    public int? Satir { get; set; }
}
