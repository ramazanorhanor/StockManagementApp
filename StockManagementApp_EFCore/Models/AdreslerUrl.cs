using System;
using System.Collections.Generic;

namespace StockManagementApp_EFCore.Models;

public partial class AdreslerUrl
{
    public int? Id { get; set; }

    public string? Aciklama { get; set; }

    public string? SqlQuery { get; set; }
}
