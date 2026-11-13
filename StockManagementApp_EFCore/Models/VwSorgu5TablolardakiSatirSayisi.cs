using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class VwSorgu5TablolardakiSatirSayisi
{
    public string Tablo { get; set; } = null!;

    public long? SatirSayisi { get; set; }
}
